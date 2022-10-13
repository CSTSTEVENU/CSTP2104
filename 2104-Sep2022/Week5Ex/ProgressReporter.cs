namespace _2104_Sep2022.Week5Ex
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    public class ProgressReporter
    {
        private string _filename;

        public ProgressReporter(string reportFilename)
        {
            this._filename = reportFilename;
        }

        public void WriteProgressToConsole(int progress)
        {
            Console.WriteLine($"%{progress * 10}");
        }

        public void WriteProgressToFile(int progress)
        {
            File.WriteAllText(this._filename, (progress * 10).ToString());
        }
    }
}
