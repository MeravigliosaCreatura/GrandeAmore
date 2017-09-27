using System;
using System.IO;


namespace Task1
{
    public class Checker
    {
        public FileInfo CheckFileSize(FileInfo file, double minSize, double maxSize)
        {
            if (file != null)
            {
                long size = file.Length / 1024;
                bool sizeCondition = (minSize <= size) && (size <= maxSize);
                if(sizeCondition)
                {
                    return file;
                }
            }
            return null;
        }
        public FileInfo CheckFileDate(FileInfo file, DateTime minTime, DateTime maxTime)
        {
            if (file != null)
            {
                DateTime date = file.CreationTime;
                bool dateCondition = (DateTime.Compare(date, minTime) >= 0) && (DateTime.Compare(date, maxTime) <= 0);
                if (dateCondition)
                {
                    return file;
                }
            }
            return null;
        }
        public FileInfo CheckFileAttributeIsHidden(FileInfo file)
        {
            if (file != null)
            {
                FileAttributes attributes = File.GetAttributes(file.FullName);
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    return file;
                }
            }
            return null;
        }
        public FileInfo CheckFileAttributeIsReadOnly(FileInfo file)
        {
            if (file != null)
            {
                FileAttributes attributes = File.GetAttributes(file.FullName);
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    return file;
                }
            }
            return null;
        }
    }
    
}
