# Kea - a webtoons downloader<img align="right" src="https://user-images.githubusercontent.com/50629201/89736764-12812c80-da6c-11ea-881f-4027922270e6.png" alt="drawing" width="200"/>  
###### *with GUI and everything!*  
Kea is an appication for downloading comics from https://www.webtoons.com for personal, offline use.
## How To: Download
You can find the latest release on the right under the "About" section in the "Releases" tab.  
Click on it and then click on the .zip file that isn't named "Source code".  
After the .zip folder downloaded unzip it and run Kea.exe.  
*(all files in the Kea folder need to stay in the same directory)*

To edit Kea, download everything and open ***Kea.sln*** in Visual Studio.
## How To: Use
![enterIntoQueue](https://user-images.githubusercontent.com/50629201/89735665-87506880-da64-11ea-8b7d-213c9d179870.gif)
1. enter all links of the comics you want to download into the uppermost text field  
	(Links must be seperated by a line break)
2. press the ***add all to queue*** button to, uh... add them to the queue  
	(If a comic does not get added, the link was invalid)
3. Use ***remove selected*** and ***remove all*** to delete comics you dont want to download
![Annotation 2020-08-09 171732](https://user-images.githubusercontent.com/50629201/89736045-034bb000-da67-11ea-825b-44e8ee6f67b5.png)  
4. Select a save folder by pressing the ***folder*** button  
5. Check ***each catoon*** for the application to save all chapters of a cartoon under a common folder (***each chapter*** works likewise)  
6. The images of a chapter can either be saved as a single PDF document or multible images (.jpg)  
	(since all images already get bundled together if a PDF is created, the option ***each chapter*** is deactivated)  
7. Now you can click the ***start*** button and wait (all controls should be deactivated until the download is done)  
## Contact me
my discord tag is: Rusting Robot#7758  
or write me an email: rusting.robot.scratch@gmail.com 
## used packages
- **HtmlAgilityPack** - for parsing HTML
- **ITextSharp** - for converting images to a PDF file
