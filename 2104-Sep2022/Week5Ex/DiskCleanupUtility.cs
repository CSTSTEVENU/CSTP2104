namespace _2104_Sep2022.Week5Ex
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DiskCleanupUtility
    {
        public delegate void Reporter(int percentComplete);

        /// <summary>
        /// Assume this is a long running function that needs to report its progress
        /// </summary>
        /// <param name="length"></param>
        /// <param name="progressReporter"></param>
        public void Cleanup(int length, Reporter progressReporter)
        {
            for (int i = 0; i < length; i++)
            {
                System.Threading.Thread.Sleep(10); // simulate doing hard work
                progressReporter(i);
            }
        }
    }
}
