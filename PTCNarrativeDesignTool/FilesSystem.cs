namespace PTCNarrativeDesignTool
{
    internal static class FilesSystem
    {
        public static bool IsDirectory(string _path)
        {
            try
            {
                if (!File.Exists(_path))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException _exeption)
            {
                Console.WriteLine($"{_path} does not exist");
            }

            return true;
        }

        public static bool WriteFile(string _path, string _content)
        {
            if (!IsDirectory(_path))
            {
                return false;
            }
            using (StreamWriter _writer = new StreamWriter(_path))
            {
                _writer.WriteLine(_content);
            }
            return true;
        }

        public static bool ReadAllLine(string _path, ref string _context)
        {
            if (!IsDirectory(_path))
            {
                return false;
            }
            using (StreamReader _reader = new StreamReader(_path))
            {
                string _line = "";
                while ((_line = _reader.ReadLine()) != null)
                    Console.WriteLine(_line);
            }
            return true;
        }

        public static string[] ReadAllLines(string _path)
        {
            if (!IsDirectory(_path))
            {
                return new string[] { };
            }
            string[] _result = File.ReadAllLines(_path);
            return _result;
        }
    }
}
