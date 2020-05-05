![Presentation](https://github.com/Mihai-Canea/PingTester/blob/master/Assets/PingTester.png)
# PingTester
![Presentation](https://github.com/Mihai-Canea/PingTester/blob/master/Assets/pingTesterVisual.png)

### About

PingTester is an Open Source Software that allows you to do Subdomain Enumeration in a easy way.
The Software is written in **C# Windows Form Project**.

### Tools used

- Subdomain Enumeration:
  - [Amass](https://github.com/OWASP/Amass)
  - [Subfinder](https://github.com/subfinder/subfinder)
- [httprobe](https://github.com/tomnomnom/httprobe)
  
![Presentation](https://github.com/Mihai-Canea/PingTester/blob/master/Assets/pingTesterAmass.png)

## Settings
The first thing to do is to add the working path and tools folder in `Tools / settings`

Working folder: where the explort will be saved (ex. tesla.com.txt)
Tools folder:
```
Tools
┬── amass.exe
├── subfinder.exe
└── httprobe.exe
```

## Building PingTester
First, clone the repository or download the latest zip.

```
git clone https://github.com/Mihai-Canea/PingTester.git
````
### Build using IDE
* [Visual Studio Community](https://visualstudio.microsoft.com/it/vs/community/) 2019 for ```Windows``` builds.

Open ```PingTesterSolution.sln``` in selected IDE and run ```Build``` command.
