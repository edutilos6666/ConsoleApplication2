using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface IReadable 
    {
        bool IsReadable();
        void Read(); 
    }

    interface IWritable
    {
        bool IsWritable();
        void Write(); 
    }

    interface IExecutable
    {
        bool IsExecutable();
        void Execute(); 
    }



    class CustomFile : IReadable, IWritable, IExecutable
    {
        public String Name { get; set;  }
        public String FolderName { get; set;  }
        public long Size { get; set;  }
        public bool Readable { get; set;  }
        public bool Writable { get; set;  }
        public bool Executable { get; set;  }
 
        public CustomFile(String name, String folderName, long size , bool readable , bool writable , bool executable)
        {
            this.Name = name;
            this.FolderName = folderName;
            this.Size = size;
            this.Readable = readable;
            this.Writable = writable;
            this.Executable = executable; 
        }

        public CustomFile()
        {

        }

        public void AllOnce()
        {
            Read();
            Write();
            Execute(); 
        }

        public void PrettyPrint()
        {
            String nl = "\r\n";
            String msg = "Name = {0}{1}FolderName = {2}{1}Size = {3}{1}, RWE = {4}{5}{6}";
            msg = String.Format(msg, this.Name, nl, this.FolderName, nl, this.Size, nl, this.Readable, this.Writable, this.Executable);
            Console.WriteLine(msg); 
        }

        public void Execute()
        {
            if (IsExecutable())
                Console.WriteLine("{0} was executed.", this.Name);
            else
                Console.WriteLine("{0} is not executable.", this.Name); 
        }

        public bool IsExecutable()
        {
            return this.Executable; 
        }

        public bool IsReadable()
        {
            return this.Readable; 
        }

        public bool IsWritable()
        {
            return this.Writable; 
        }

        public void Read()
        {
            if (IsReadable())
                Console.WriteLine("{0} was read.", this.Name);
            else
                Console.WriteLine("{0} is not readable", this.Name); 
        }

        public void Write()
        {
            if (IsWritable())
                Console.WriteLine("{0} was written.", this.Name);
            else
                Console.WriteLine("{0} is not writable.", this.Name); 
        }
    }

}
