using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessorService
{
	[RunInstaller(true)]
	public class FileProcessorServiceInstaller : Installer
	{
		public FileProcessorServiceInstaller()
		{
			var serviceInstaller = new ServiceInstaller();
			serviceInstaller.StartType = ServiceStartMode.Manual;
			serviceInstaller.ServiceName = FileProcessor.SericeName;
			serviceInstaller.DisplayName = FileProcessor.SericeName;

			Installers.Add(serviceInstaller);

			var processInstaller = new ServiceProcessInstaller();
			processInstaller.Account = ServiceAccount.User;
            processInstaller.Username = @".\Дмитрий";
            processInstaller.Password = "Hjvfirf1";

            Installers.Add(processInstaller);
		}
	}
}
