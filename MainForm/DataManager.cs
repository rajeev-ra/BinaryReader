using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MainForm
{
    public class DataManager
    {
        string _file = "";
        BinaryReader _reader;
        public DataManager(string iFile)
        {
            _file = iFile;
            _reader = new BinaryReader(File.Open(_file, FileMode.Open, FileAccess.Read));
        }

        public int GetByteCount()
        {
            return (int)_reader.BaseStream.Length;
        }

        public Byte[] ReadBytes(int startPos, int length)
        {
            if(startPos < GetByteCount() && startPos > -1)
            {
                int size = length < GetByteCount() - startPos ? length : GetByteCount() - startPos;
                _reader.BaseStream.Seek(startPos, SeekOrigin.Begin);
                Byte[] data = _reader.ReadBytes(size);
                return data;
            }
            return new Byte[0];
        }
    }
}
