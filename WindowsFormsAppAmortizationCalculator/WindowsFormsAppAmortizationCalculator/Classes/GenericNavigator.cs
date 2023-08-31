using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsAppAmortizationCalculator.Classes
{
    public delegate void ObjectNavigatedHandler<T>(T obj);

    public class GenericNavigator<T> where T : class, new()
    {
        public event ObjectNavigatedHandler<T> ObjectNavigated;

        private List<T> _List;
        private int _currentPosition;
        private string _fileName = "Untitled";
        
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

        public string FileName { get => _fileName; set => _fileName = value; }

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


        public string SaveToFile(string filename) {
            FileStream Fs = null;
            int count = 0;


            if (_List == null) {
                return "There is no item to save";
            }

            Fs = new FileStream(filename, FileMode.OpenOrCreate, 
                FileAccess.ReadWrite
                , FileShare.Read);

            foreach (T obj in _List) { 
                ISavable tmp = (ISavable)obj;
                tmp.WriteObject(Fs);
                count++;
            }

            //Fs.Flush();
            Fs.Close();

            return count.ToString() + " Record(s) are saved";
        }

        public string Save() {
            return SaveToFile(_fileName);
        }
        public string ReadFromFile(string filename) {

            FileStream fs = null;
            T tmp = null;
            ISavable ts = null;
            T tmp_read = null;
            int count = 0;



            fs = new FileStream(filename, FileMode.OpenOrCreate,
              FileAccess.ReadWrite
              , FileShare.Read);

           while (fs.Position != fs.Length) {
                tmp = new T();
                ts = (ISavable)tmp;

                tmp_read = (T) ts.ReadObject(fs);
                this.Add(tmp_read);
                count++;
            }

            fs.Close();
            return count.ToString() + " record(s) being read";
        }
        public string Read() { 
            return ReadFromFile(_fileName);
        }
        public string ExportToCSV(string filename) {
            FileStream Fs = null;
            int count = 0;
            StreamWriter Writer = null;
            T tmp = new T();
            ISavable tmp_is = (ISavable)tmp;

            if (_List == null)
            {
                return "There is no item to export";
            }

            Fs = new FileStream(filename, FileMode.OpenOrCreate,
                FileAccess.ReadWrite
                , FileShare.Read);

            Writer = new StreamWriter(Fs);
            Writer.WriteLine(tmp_is.getCSVHeader());
            foreach (T obj in _List) {
                tmp_is = (ISavable)obj;
                Writer.WriteLine(tmp_is.getCSVContent());
                count++;
            }

            Writer.Flush();
            Writer.Close();
            Fs.Close();

            return count.ToString() + " Record(s) are exported to CSV [" + filename + "]";

        }
    }


    public interface ISavable {

        void WriteObject(FileStream FS);
        object ReadObject(FileStream FS);
        string getCSVHeader();
        string getCSVContent();


    }
}
