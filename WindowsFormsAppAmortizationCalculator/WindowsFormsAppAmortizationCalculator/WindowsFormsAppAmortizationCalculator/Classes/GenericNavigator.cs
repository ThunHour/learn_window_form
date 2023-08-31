using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsAppAmortizationCalculator.Classes
{
    public enum SortLoanDetail
    {
        LoanID = 1,
        LoanName = 2,
        LoanAmount = 3,
        LoanRatePerYear = 4,

        LoanDate = 5,
        Loantenure = 6,

    }
    public delegate void ObjectNavigatedHandler<T>(T obj);

    public class GenericNavigator<T> where T : class,new()
    {
        public event ObjectNavigatedHandler<T> ObjectNavigated;

        private List<T> _List;
        private string _filename = "Untitled";
        private int _currentPosition;
        
        public GenericNavigator() { }
        public GenericNavigator(List<T> list)
        {
            this._List = list;
        }

        public List<T> getListOf()
        {
            return _List;
        }

        public int Count
        {
            get
            {
                if (_List == null)
                {
                    return 0;
                }
                else
                {
                    return _List.Count;
                }
            }
        }

        public void Add(T Obj)
        {
           
            if (Obj == null) { return; }

            if (_List == null)
            {
                _List = new List<T>();
                _List.Add(Obj);
            }
            else
            {
                _List.Add(Obj);
            }
            _currentPosition = _List.Count - 1;
        }

        public T MoveFirst()
        {
            T tmp = null;


            if (_List == null || _List.Count == 0)
            {
                return null;
            }

            if (_currentPosition > 0)
            {
                _currentPosition = 0;
            }

            tmp = _List[_currentPosition];

            if (ObjectNavigated != null) {
                ObjectNavigated(tmp);
            }

            return tmp;
        }

        public T MoveLast()
        {
            T tmp = null;

            if (_List == null || _List.Count == 0)
            {
                return null;
            }

            if (_currentPosition < _List.Count - 1)
            {
                _currentPosition = _List.Count - 1;
            }

            tmp = _List[_currentPosition];

            if (ObjectNavigated != null)
            {
                ObjectNavigated(tmp);
            }

            return tmp;
        }

        public T MovePrevious()
        {
            T tmp = null;

            if (_List == null || _List.Count == 0)
            {
                return null;
            }

            if (_currentPosition > 0)
            {
                _currentPosition--;
            }

            tmp = _List[_currentPosition];

            if (ObjectNavigated != null) {
                ObjectNavigated(tmp);
            }

            return tmp;
        }

        public T MoveNext()
        {
            T tmp = null;

            if (_List == null || _List.Count == 0)
            {
                return null;
            }

            if (_currentPosition < _List.Count - 1)
            {
                _currentPosition++;
            }

            tmp = _List[_currentPosition];

            if (ObjectNavigated != null)
            {
                ObjectNavigated(tmp);
            }

            return tmp;
        }

        public int CurrentPosition
        {
            get
            {
                if (_List == null || _List.Count == 0)
                {
                    return -1;
                }
                return _currentPosition + 1;
            }
        }

        public string FileName { get => _filename; set => _filename = value; }

        public void Update(T old_obj, T new_obj)
        {
            for (int i = 0; i <= _List.Count - 1; i++)
            {
                if (_List[i].Equals(old_obj))
                {
                    _List[i] = new_obj;
                }
            }
        }

        public void Delete(T obj)
        {

            var The_remain_objs = from ex in _List
                                     where !ex.Equals(obj)
                                     select ex;

            if (The_remain_objs == null)
            {
                _currentPosition = -1;
                _List = null;
            }

            if (The_remain_objs != null && The_remain_objs.Count() == 0)
            {
                _currentPosition = -1;
                _List = null;
            }

            _List = The_remain_objs.ToList();

            if (_currentPosition > _List.Count - 1)
            {
                _currentPosition = _List.Count - 1;
            }

        }
        public string SaveTofile(string filename)
        {
            FileStream Fs = null;
            int count = 0;
            if (_List == null)
            {
                return "There is no item to save"; ;
            }
            Fs=new FileStream(filename, FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
            foreach(T obj in _List)
            {
                ISaveable temp=(ISaveable)obj;
                temp.WriteObject(Fs);
                count++;
            }
            Fs.Flush();
            Fs.Close();
            return count.ToString()+" Record(s) are saved";
        }
        public string Save()
        {
            return SaveTofile(FileName);
        }
        public string ReadFromFile(string filename)
        {
            FileStream fileStream = null;
            T temp = null;
            ISaveable ts = null;
            T temp_read = null;
            int count = 0;

            fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            while (fileStream.Position != fileStream.Length)
            {
                temp = new T();
                ts=(ISaveable)temp;
                temp_read =(T) ts.ReadObject(fileStream);
                this.Add(temp_read);
                count++;

            }
            filename.Clone();
            return count.ToString() + " record(s) being read";


        }


    }

    public interface ISaveable
    {
         void WriteObject(FileStream Fs);
         object ReadObject(FileStream Fs);
      
    }
}
