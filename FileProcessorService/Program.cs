using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace FileProcessorService
{
	class Program
	{
		static void Main(string[] args)
		{
			string currentDir = Path.GetDirectoryName(Path.GetFullPath(Process.GetCurrentProcess().MainModule.FileName));

			string inQueue = @".\private$\todoQueue";
			string outQueue = @".\private$\doneQueue"; ;

            //Debugger.Launch();
           // InstallUtil.exe "D:\mentoring\window servises\Samples\FileProcessorService\bin\Debug\FileProcessorService.exe"

            var fileProcessor = new FileProcessor(inQueue, outQueue, 1, 10);

			ServiceBase.Run(fileProcessor);
		}
	}
}
