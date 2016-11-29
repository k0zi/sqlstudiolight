using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace DatabaseTest
{
    /// <summary>
    /// 
    /// </summary>
    public class ScriptFiles : INotifyPropertyChanged
    {
        #region Variables and fields
        private List<ExtensionView> _extensions;
        private List<FileInfo> _files;
        private bool _loaded;
        #endregion //Variables and fields

        #region Constructors
        public ScriptFiles(string path)
        {
            this._files = new DirectoryInfo(path).GetFiles().ToList<FileInfo>();
            this._extensions = new List<ExtensionView>();
            foreach (var f in _files)
            {
                if (!_extensions.Contains(new ExtensionView(f.Extension)))
                {
                    _extensions.Add(new ExtensionView(f.Extension));
                }
            }
            OnPropertyChange("Files");
            OnPropertyChange("Extensions");
        }
        #endregion //Constructors

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion //Events

        #region Properties
        
        [Bindable(true)]
        public bool Loaded
        {
            get { return _loaded; }
            set {
                if (_loaded != value)
                {
                    _loaded = value;
                    OnPropertyChange("Loaded");
                }
            }
        }

        [Bindable(true)]
        public List<FileInfo> Files
        {
            get { return _files; }
            set
            {
                if (_files != value)
                {
                    _files = value;
                    OnPropertyChange("Files");
                }
            }
        }
        [Bindable(true)]
        public List<ExtensionView> Extensions 
        {
            get { return _extensions; }
            set
            {
                if (_extensions != value)
                {
                    _extensions = value;
                    OnPropertyChange("Extensions");
                }
            }
        }
        #endregion //Properties

        #region Methods
        private void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion //Methods

        #region Functions
        public List<FileInfo> GetFilesWithExtension(string extension)
        {
            List<FileInfo> result = new List<FileInfo>();
            foreach (var item in _files)
            {
                if (item.Extension == extension)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public string GetScript(FileInfo info)
        {
            using (StreamReader sr = new StreamReader(info.FullName))
            {
                string s = sr.ReadToEnd();
                s = s.Replace("GO", ";");
                s = s.Replace("Go", ";");
                s = s.Replace("gO", ";");
                s = s.Replace("go", ";");
                return s;
            }
        }
        #endregion //Functions
    }

    public class ExtensionView : INotifyPropertyChanged
    {
        private string name;
        private bool isChecked;
        private string p;

        public ExtensionView()
        {
            this.name = "";
            this.isChecked = false;
        }

        public ExtensionView(string p)
        {
            this.name = p;
        }

        [Bindable(true)]
        public bool IsChecked
        {
            get { return isChecked; }
            set {
                if (IsChecked != value)
                {
                    isChecked = value;
                    OnPropertyChange("IsChecked");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is ExtensionView)
            {
                if (this.name == (obj as ExtensionView).Name)
                {
                    return true;
                }
            }
            return false;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
