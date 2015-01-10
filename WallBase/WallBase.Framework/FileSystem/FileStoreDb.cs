﻿using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WallBase.Framework.FileSystem
{
    public partial class FileStoreDb : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void Insertbe_FileStoreDirectory(FileStoreDirectory instance);
        partial void Updatebe_FileStoreDirectory(FileStoreDirectory instance);
        partial void Deletebe_FileStoreDirectory(FileStoreDirectory instance);
        partial void Insertbe_FileStoreFileThumb(FileStoreFileThumb instance);
        partial void Updatebe_FileStoreFileThumb(FileStoreFileThumb instance);
        partial void Deletebe_FileStoreFileThumb(FileStoreFileThumb instance);
        partial void Insertbe_FileStoreFile(FileStoreFile instance);
        partial void Updatebe_FileStoreFile(FileStoreFile instance);
        partial void Deletebe_FileStoreFile(FileStoreFile instance);
        #endregion


        public FileStoreDb(string connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public FileStoreDb(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public FileStoreDb(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public FileStoreDb(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<FileStoreDirectory> FileStoreDirectories
        {
            get
            {
                return this.GetTable<FileStoreDirectory>();
            }
        }

        public System.Data.Linq.Table<FileStoreFileThumb> FileStoreFileThumbs
        {
            get
            {
                return this.GetTable<FileStoreFileThumb>();
            }
        }

        public System.Data.Linq.Table<FileStoreFile> FileStoreFiles
        {
            get
            {
                return this.GetTable<FileStoreFile>();
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.be_FileStoreDirectory")]
    public partial class FileStoreDirectory : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private System.Guid _Id;

        private System.Nullable<System.Guid> _ParentID;

        private System.Guid _BlogID;

        private string _Name;

        private string _FullPath;

        private System.DateTime _CreateDate;

        private System.DateTime _LastAccess;

        private System.DateTime _LastModify;

        private EntitySet<FileStoreFile> _be_FileStoreFiles;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(System.Guid value);
        partial void OnIdChanged();
        partial void OnParentIDChanging(System.Nullable<System.Guid> value);
        partial void OnParentIDChanged();
        partial void OnBlogIDChanging(System.Guid value);
        partial void OnBlogIDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnFullPathChanging(string value);
        partial void OnFullPathChanged();
        partial void OnCreateDateChanging(System.DateTime value);
        partial void OnCreateDateChanged();
        partial void OnLastAccessChanging(System.DateTime value);
        partial void OnLastAccessChanged();
        partial void OnLastModifyChanging(System.DateTime value);
        partial void OnLastModifyChanged();
        #endregion

        public FileStoreDirectory()
        {
            this._be_FileStoreFiles = new EntitySet<FileStoreFile>(new Action<FileStoreFile>(this.attach_be_FileStoreFiles), new Action<FileStoreFile>(this.detach_be_FileStoreFiles));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "UniqueIdentifier NOT NULL", IsPrimaryKey = true)]
        public System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ParentID", DbType = "UniqueIdentifier")]
        public System.Nullable<System.Guid> ParentID
        {
            get
            {
                return this._ParentID;
            }
            set
            {
                if ((this._ParentID != value))
                {
                    this.OnParentIDChanging(value);
                    this.SendPropertyChanging();
                    this._ParentID = value;
                    this.SendPropertyChanged("ParentID");
                    this.OnParentIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_BlogID", DbType = "UniqueIdentifier NOT NULL")]
        public System.Guid BlogID
        {
            get
            {
                return this._BlogID;
            }
            set
            {
                if ((this._BlogID != value))
                {
                    this.OnBlogIDChanging(value);
                    this.SendPropertyChanging();
                    this._BlogID = value;
                    this.SendPropertyChanged("BlogID");
                    this.OnBlogIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FullPath", DbType = "VarChar(1000) NOT NULL", CanBeNull = false)]
        public string FullPath
        {
            get
            {
                return this._FullPath;
            }
            set
            {
                if ((this._FullPath != value))
                {
                    this.OnFullPathChanging(value);
                    this.SendPropertyChanging();
                    this._FullPath = value;
                    this.SendPropertyChanged("FullPath");
                    this.OnFullPathChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CreateDate", DbType = "DateTime NOT NULL")]
        public System.DateTime CreateDate
        {
            get
            {
                return this._CreateDate;
            }
            set
            {
                if ((this._CreateDate != value))
                {
                    this.OnCreateDateChanging(value);
                    this.SendPropertyChanging();
                    this._CreateDate = value;
                    this.SendPropertyChanged("CreateDate");
                    this.OnCreateDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LastAccess", DbType = "DateTime NOT NULL")]
        public System.DateTime LastAccess
        {
            get
            {
                return this._LastAccess;
            }
            set
            {
                if ((this._LastAccess != value))
                {
                    this.OnLastAccessChanging(value);
                    this.SendPropertyChanging();
                    this._LastAccess = value;
                    this.SendPropertyChanged("LastAccess");
                    this.OnLastAccessChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LastModify", DbType = "DateTime NOT NULL")]
        public System.DateTime LastModify
        {
            get
            {
                return this._LastModify;
            }
            set
            {
                if ((this._LastModify != value))
                {
                    this.OnLastModifyChanging(value);
                    this.SendPropertyChanging();
                    this._LastModify = value;
                    this.SendPropertyChanged("LastModify");
                    this.OnLastModifyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "be_FileStoreDirectory_be_FileStoreFile", Storage = "_be_FileStoreFiles", ThisKey = "Id", OtherKey = "ParentDirectoryID")]
        public EntitySet<FileStoreFile> FileStoreFiles
        {
            get
            {
                return this._be_FileStoreFiles;
            }
            set
            {
                this._be_FileStoreFiles.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_be_FileStoreFiles(FileStoreFile entity)
        {
            this.SendPropertyChanging();
            entity.FileStoreDirectory = this;
        }

        private void detach_be_FileStoreFiles(FileStoreFile entity)
        {
            this.SendPropertyChanging();
            entity.FileStoreDirectory = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.be_FileStoreFileThumbs")]
    public partial class FileStoreFileThumb : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private System.Guid _thumbnailId;

        private System.Guid _FileId;

        private int _size;

        private System.Data.Linq.Binary _contents;

        private EntityRef<FileStoreFile> _be_FileStoreFile;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnthumbnailIdChanging(System.Guid value);
        partial void OnthumbnailIdChanged();
        partial void OnFileIdChanging(System.Guid value);
        partial void OnFileIdChanged();
        partial void OnsizeChanging(int value);
        partial void OnsizeChanged();
        partial void OncontentsChanging(System.Data.Linq.Binary value);
        partial void OncontentsChanged();
        #endregion

        public FileStoreFileThumb()
        {
            this._be_FileStoreFile = default(EntityRef<FileStoreFile>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_thumbnailId", DbType = "UniqueIdentifier NOT NULL", IsPrimaryKey = true)]
        public System.Guid thumbnailId
        {
            get
            {
                return this._thumbnailId;
            }
            set
            {
                if ((this._thumbnailId != value))
                {
                    this.OnthumbnailIdChanging(value);
                    this.SendPropertyChanging();
                    this._thumbnailId = value;
                    this.SendPropertyChanged("thumbnailId");
                    this.OnthumbnailIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FileId", DbType = "UniqueIdentifier NOT NULL")]
        public System.Guid FileId
        {
            get
            {
                return this._FileId;
            }
            set
            {
                if ((this._FileId != value))
                {
                    if (this._be_FileStoreFile.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnFileIdChanging(value);
                    this.SendPropertyChanging();
                    this._FileId = value;
                    this.SendPropertyChanged("FileId");
                    this.OnFileIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_size", DbType = "Int NOT NULL")]
        public int size
        {
            get
            {
                return this._size;
            }
            set
            {
                if ((this._size != value))
                {
                    this.OnsizeChanging(value);
                    this.SendPropertyChanging();
                    this._size = value;
                    this.SendPropertyChanged("size");
                    this.OnsizeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_contents", DbType = "VarBinary(MAX) NOT NULL", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
        public System.Data.Linq.Binary contents
        {
            get
            {
                return this._contents;
            }
            set
            {
                if ((this._contents != value))
                {
                    this.OncontentsChanging(value);
                    this.SendPropertyChanging();
                    this._contents = value;
                    this.SendPropertyChanged("contents");
                    this.OncontentsChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "be_FileStoreFile_be_FileStoreFileThumb", Storage = "_be_FileStoreFile", ThisKey = "FileId", OtherKey = "FileID", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
        public FileStoreFile FileStoreFile
        {
            get
            {
                return this._be_FileStoreFile.Entity;
            }
            set
            {
                FileStoreFile previousValue = this._be_FileStoreFile.Entity;
                if (((previousValue != value)
                            || (this._be_FileStoreFile.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._be_FileStoreFile.Entity = null;
                        previousValue.FileStoreFileThumbs.Remove(this);
                    }
                    this._be_FileStoreFile.Entity = value;
                    if ((value != null))
                    {
                        value.FileStoreFileThumbs.Add(this);
                        this._FileId = value.FileID;
                    }
                    else
                    {
                        this._FileId = default(System.Guid);
                    }
                    this.SendPropertyChanged("be_FileStoreFile");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.be_FileStoreFiles")]
    public partial class FileStoreFile : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private System.Guid _FileID;

        private System.Guid _ParentDirectoryID;

        private string _Name;

        private string _FullPath;

        private System.Data.Linq.Binary _Contents;

        private int _Size;

        private System.DateTime _CreateDate;

        private System.DateTime _LastAccess;

        private System.DateTime _LastModify;

        private EntitySet<FileStoreFileThumb> _be_FileStoreFileThumbs;

        private EntityRef<FileStoreDirectory> _be_FileStoreDirectory;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnFileIDChanging(System.Guid value);
        partial void OnFileIDChanged();
        partial void OnParentDirectoryIDChanging(System.Guid value);
        partial void OnParentDirectoryIDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnFullPathChanging(string value);
        partial void OnFullPathChanged();
        partial void OnContentsChanging(System.Data.Linq.Binary value);
        partial void OnContentsChanged();
        partial void OnSizeChanging(int value);
        partial void OnSizeChanged();
        partial void OnCreateDateChanging(System.DateTime value);
        partial void OnCreateDateChanged();
        partial void OnLastAccessChanging(System.DateTime value);
        partial void OnLastAccessChanged();
        partial void OnLastModifyChanging(System.DateTime value);
        partial void OnLastModifyChanged();
        #endregion

        public FileStoreFile()
        {
            this._be_FileStoreFileThumbs = new EntitySet<FileStoreFileThumb>(new Action<FileStoreFileThumb>(this.attach_be_FileStoreFileThumbs), new Action<FileStoreFileThumb>(this.detach_be_FileStoreFileThumbs));
            this._be_FileStoreDirectory = default(EntityRef<FileStoreDirectory>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FileID", DbType = "UniqueIdentifier NOT NULL", IsPrimaryKey = true)]
        public System.Guid FileID
        {
            get
            {
                return this._FileID;
            }
            set
            {
                if ((this._FileID != value))
                {
                    this.OnFileIDChanging(value);
                    this.SendPropertyChanging();
                    this._FileID = value;
                    this.SendPropertyChanged("FileID");
                    this.OnFileIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ParentDirectoryID", DbType = "UniqueIdentifier NOT NULL")]
        public System.Guid ParentDirectoryID
        {
            get
            {
                return this._ParentDirectoryID;
            }
            set
            {
                if ((this._ParentDirectoryID != value))
                {
                    if (this._be_FileStoreDirectory.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnParentDirectoryIDChanging(value);
                    this.SendPropertyChanging();
                    this._ParentDirectoryID = value;
                    this.SendPropertyChanged("ParentDirectoryID");
                    this.OnParentDirectoryIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FullPath", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
        public string FullPath
        {
            get
            {
                return this._FullPath;
            }
            set
            {
                if ((this._FullPath != value))
                {
                    this.OnFullPathChanging(value);
                    this.SendPropertyChanging();
                    this._FullPath = value;
                    this.SendPropertyChanged("FullPath");
                    this.OnFullPathChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Contents", DbType = "VarBinary(MAX) NOT NULL", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
        public System.Data.Linq.Binary Contents
        {
            get
            {
                return this._Contents;
            }
            set
            {
                if ((this._Contents != value))
                {
                    this.OnContentsChanging(value);
                    this.SendPropertyChanging();
                    this._Contents = value;
                    this.SendPropertyChanged("Contents");
                    this.OnContentsChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Size", DbType = "Int NOT NULL")]
        public int Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                if ((this._Size != value))
                {
                    this.OnSizeChanging(value);
                    this.SendPropertyChanging();
                    this._Size = value;
                    this.SendPropertyChanged("Size");
                    this.OnSizeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CreateDate", DbType = "DateTime NOT NULL")]
        public System.DateTime CreateDate
        {
            get
            {
                return this._CreateDate;
            }
            set
            {
                if ((this._CreateDate != value))
                {
                    this.OnCreateDateChanging(value);
                    this.SendPropertyChanging();
                    this._CreateDate = value;
                    this.SendPropertyChanged("CreateDate");
                    this.OnCreateDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LastAccess", DbType = "DateTime NOT NULL")]
        public System.DateTime LastAccess
        {
            get
            {
                return this._LastAccess;
            }
            set
            {
                if ((this._LastAccess != value))
                {
                    this.OnLastAccessChanging(value);
                    this.SendPropertyChanging();
                    this._LastAccess = value;
                    this.SendPropertyChanged("LastAccess");
                    this.OnLastAccessChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LastModify", DbType = "DateTime NOT NULL")]
        public System.DateTime LastModify
        {
            get
            {
                return this._LastModify;
            }
            set
            {
                if ((this._LastModify != value))
                {
                    this.OnLastModifyChanging(value);
                    this.SendPropertyChanging();
                    this._LastModify = value;
                    this.SendPropertyChanged("LastModify");
                    this.OnLastModifyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "be_FileStoreFile_be_FileStoreFileThumb", Storage = "_be_FileStoreFileThumbs", ThisKey = "FileID", OtherKey = "FileId")]
        public EntitySet<FileStoreFileThumb> FileStoreFileThumbs
        {
            get
            {
                return this._be_FileStoreFileThumbs;
            }
            set
            {
                this._be_FileStoreFileThumbs.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "be_FileStoreDirectory_be_FileStoreFile", Storage = "_be_FileStoreDirectory", ThisKey = "ParentDirectoryID", OtherKey = "Id", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
        public FileStoreDirectory FileStoreDirectory
        {
            get
            {
                return this._be_FileStoreDirectory.Entity;
            }
            set
            {
                FileStoreDirectory previousValue = this._be_FileStoreDirectory.Entity;
                if (((previousValue != value)
                            || (this._be_FileStoreDirectory.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._be_FileStoreDirectory.Entity = null;
                        previousValue.FileStoreFiles.Remove(this);
                    }
                    this._be_FileStoreDirectory.Entity = value;
                    if ((value != null))
                    {
                        value.FileStoreFiles.Add(this);
                        this._ParentDirectoryID = value.Id;
                    }
                    else
                    {
                        this._ParentDirectoryID = default(System.Guid);
                    }
                    this.SendPropertyChanged("be_FileStoreDirectory");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_be_FileStoreFileThumbs(FileStoreFileThumb entity)
        {
            this.SendPropertyChanging();
            entity.FileStoreFile = this;
        }

        private void detach_be_FileStoreFileThumbs(FileStoreFileThumb entity)
        {
            this.SendPropertyChanging();
            entity.FileStoreFile = null;
        }
    }
}
#pragma warning restore 1591
