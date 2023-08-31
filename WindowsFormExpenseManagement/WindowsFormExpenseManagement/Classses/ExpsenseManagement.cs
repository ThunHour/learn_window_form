using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormExpenseManagement.Classses
{
   
    public enum SortExpenseFeild
    {
        ExpsenseID = 1,
        ExpenseOn = 2,
        ExpenseAmount = 3,
        ExpenseDate = 4,
        ExpenseDesc = 5
    }
    public enum SaveFileOption
    {
        SaveFileOptStream = 1,
        SaveFileOptBinary = 2,
        SaveFileOptSerialization = 3
    }
    public class ExpsenseManagement
    {

        private Expense[] _ListExpense;
        private int _currentPosition;
    
        public ExpsenseManagement() { }
        public ExpsenseManagement(Expense[] expenseList) {
            this._ListExpense = expenseList;

        }
        public Expense[] getListOfExpense() {
           
                return _ListExpense;
        }
        public int Count
        {
            get {
                if (_ListExpense == null)
                {
                    return 0;
                }
                return _ListExpense.Length;
            }
        }
        public void add(Expense obj)
           
        {
            Expense[] temp;
            if (_ListExpense == null || _ListExpense.Length == 0)
            {
                _ListExpense = new Expense[1];
                _ListExpense[0] = obj;
            }
            else
            {
                temp = new Expense[_ListExpense.Length + 1];
                Array.Copy(_ListExpense, temp, _ListExpense.Length);
                  _ListExpense= temp;
                    temp = null;
                _ListExpense[_ListExpense.Length - 1] = obj;
                _currentPosition = _ListExpense.Length - 1;
            }
        }
        public Expense MoveFirst()
        {
            if (_ListExpense == null | _ListExpense.Length == 0)
            {
                return null;
            }     else if (_currentPosition < 0)
            {
                return null;

            }
            else if (_currentPosition < 0)
            {
                return null;

            }
            else if (_currentPosition > 0)
            {
                _currentPosition = 0;
                
            }
            return _ListExpense[_currentPosition];
        }
        public Expense MoveLast()
        {
            if (_ListExpense == null | _ListExpense.Length == 0)
            {
                return null;
            }
            else if (_currentPosition < _ListExpense.Length)
            {
                _currentPosition = _ListExpense.Length - 1;
            }
            return _ListExpense[_currentPosition];
        }
        public Expense MovePrevious()
        {
            if (_ListExpense == null | _ListExpense.Length == 0)
            {
                return null;
            }
            else if (_currentPosition < 0)
            {
                return null;

            }else if (_currentPosition > 0)
            {
                _currentPosition--;
            }
            return _ListExpense[_currentPosition];
        }
        public Expense MoveNext()
        {
            if (_ListExpense == null | _ListExpense.Length == 0)
            {
                return null;
            }
            else if (_currentPosition < _ListExpense.Length-1)
            {
                _currentPosition++;

            }
            return _ListExpense[_currentPosition];
        }
        public int CurrentPosition
        {
            get
            {
                if (_ListExpense == null || _ListExpense.Length == 0)
                {
                    return 0;
                }
                return _currentPosition+1;
            }
        }
        public float getTotalExpense()
        {
            float _total = 0.0f;
            if (_ListExpense == null || _ListExpense.Length == 0)
            {
                return 0.0f;
            }
            foreach(Expense exp in _ListExpense)
            {
                _total += exp.ExpenseAmount;
            }
            return _total;



        }
        public void Update(Expense old,Expense exp_new)
        {
             for(int i = 0; i <= _ListExpense.Length - 1;i++)
            {
                if (_ListExpense[i].ExpenseID == old.ExpenseID)
                {
                    _ListExpense[i] = exp_new;
                }
            }
        }
        public void Delete(Expense obj)
        {
            var The_remain_expense = from ex in _ListExpense
                                     where ex.ExpenseID != obj.ExpenseID
                                     select ex;
            if (The_remain_expense == null)
            {
                _currentPosition = -1;
                _ListExpense = null;
            }else if (The_remain_expense!=null &&The_remain_expense.Count()==0) {
                _currentPosition = -1;
                _ListExpense = null;
            }
            _ListExpense = The_remain_expense.ToArray();
            if (_currentPosition > _ListExpense.Length - 1)
            {
                _currentPosition=_ListExpense.Length-1;
            }
        }
        public void SaveToFile(string flename,SaveFileOption saveFileOption =SaveFileOption.SaveFileOptStream)
        {
            FileStream fs=new FileStream(flename, FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
            StreamWriter sw = null;
            BinaryWriter bw = null;
            BinaryFormatter BSerializer = null;

            if (saveFileOption == SaveFileOption.SaveFileOptStream)
            {
                sw=new StreamWriter(fs);
            }else if(saveFileOption == SaveFileOption.SaveFileOptBinary)
            {
                bw=new BinaryWriter(fs);
            }
            if (saveFileOption == SaveFileOption.SaveFileOptSerialization)
            {
                BSerializer = new BinaryFormatter();
            }
            foreach (Expense exp in _ListExpense)
            {
                if (saveFileOption == SaveFileOption.SaveFileOptStream)
                {
                    sw.WriteLine(exp.ExpenseID + "|" + exp.ExpenseON + "|"
                        + exp.ExpenseAmount.ToString() + "|" + exp.ExpenseDate.ToString() + "|" + exp.ExpenseDecription);

                }
                if (saveFileOption == SaveFileOption.SaveFileOptBinary)
                {
                    bw.Write(exp.ExpenseID);
                    bw.Write(exp.ExpenseON);
                    bw.Write(exp.ExpenseAmount);
                    bw.Write(exp.ExpenseDate.ToString());
                    bw.Write(exp.ExpenseDecription);
                }
                if (saveFileOption == SaveFileOption.SaveFileOptSerialization)
                {
                    BSerializer.Serialize(fs, exp);
                }
      
            }
            if(sw != null)
            {
                sw.Flush();
                sw.Close();
            }
            if (bw != null)
                {
                bw.Flush();
                bw.Close();
                }
            fs.Close();
            
        }
        public void ReadFromFile(string filename, SaveFileOption saveFileOption = SaveFileOption.SaveFileOptStream)
        {
            
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            StreamReader sw = null;
            BinaryReader bw = null;
            BinaryFormatter BSerializer = null;

            string templine = "";
            string[] arrtemp;
            Expense tempExp=null;

            if (saveFileOption == SaveFileOption.SaveFileOptStream)
            {
                _ListExpense = null;
                sw =new StreamReader(fs);
                while (!sw.EndOfStream)
                {
                    templine = sw.ReadLine();
                    arrtemp=templine.Split('|');
                    tempExp=new Expense();
                    tempExp.ExpenseID=arrtemp[0];
                    tempExp.ExpenseON=arrtemp[1];
                    tempExp.ExpenseAmount=float.Parse(arrtemp[2]);
                    tempExp.ExpenseDate = Convert.ToDateTime(arrtemp[3]);
                    tempExp.ExpenseDecription=arrtemp[4];
                    this.add(tempExp);
                }
                _currentPosition = _ListExpense.Length - 1;
            }
            if (saveFileOption == SaveFileOption.SaveFileOptBinary)
            {
                bw = new BinaryReader(fs);
                _ListExpense = null;
                while (bw.BaseStream.Position != bw.BaseStream.Length)
                {
                    tempExp = new Expense();
                    tempExp.ExpenseID = bw.ReadString();
                    tempExp.ExpenseON = bw.ReadString();
                    tempExp.ExpenseAmount = bw.ReadSingle();
                    tempExp.ExpenseDate = Convert.ToDateTime(bw.ReadString());
                    tempExp.ExpenseDecription = bw.ReadString();
                    this.add(tempExp);
                }
                _currentPosition = _ListExpense.Length - 1;

            }

            if (saveFileOption == SaveFileOption.SaveFileOptSerialization)
            {
                BSerializer = new BinaryFormatter();
                _ListExpense = null;


                while (fs.Position != fs.Length)
                {
                    tempExp = (Expense)BSerializer.Deserialize(fs);
                    this.add(tempExp);
                }
                _currentPosition = _ListExpense.Length - 1;
            }

            fs.Close();

        }

    }
}
