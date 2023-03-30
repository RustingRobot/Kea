# Kea - a webtoons downloader<img align="right" src="https://user-images.githubusercontent.com/50629201/89736764-12812c80-da6c-11ea-881f-4027922270e6.png" alt="drawing" width="200"/>  
###### *with GUI and everything!*  
Kea is an appication for downloading comics from https://www.webtoons.com for personal, offline use.  
  
>***Note:*** Kea is currently not actively maintained and will stay that way for the foreseeable future. It works fine in most cases but I currently don't have the time to iron out any bugs. I would like to rework the entire project, but that must wait for now. Check out [Advanced-Kea](https://github.com/Anything144/Advanced-Kea) by Anything144 for a bug-fixed version of Kea.
## How To: Download
Download [Kea v.1.3.4](https://github.com/RustingRobot/Kea/releases/download/v1.3.4/Kea.v1.3.4.zip)
or look at all releases [here](https://github.com/RustingRobot/Kea/releases).  
After the .zip folder downloaded unzip it and run Kea.exe.  
*(all files in the Kea folder need to stay in the same directory)*

To edit Kea, download everything and open ***Kea.sln*** in Visual Studio.
## How To: Use
![enterIntoQueue](https://user-images.githubusercontent.com/50629201/89735665-87506880-da64-11ea-8b7d-213c9d179870.gif)
* enter all links of the comics you want to download into the uppermost text field  
	(Links must be seperated by a line break)
>***Note:*** please don't use links of specific chapters  
>This would work: https://www.webtoons.com/en/action/hero-killer/list?title_no=2745  
>But this wouldn't: https://www.webtoons.com/en/action/hero-killer/episode-1/viewer?title_no=2745&episode_no=1  
* press the ***add all to queue*** button to, uh... add them to the queue  
	(If a comic does not get added, the link was invalid)
* Use ***remove selected*** and ***remove all*** to delete comics you dont want to download
<!-- end of the list -->
![startEndChapter](https://user-images.githubusercontent.com/50629201/106370729-322f4880-635d-11eb-8dc9-d3e4b274e083.gif)
* The default start chapter will always be 1 and the default end chapter 'end'
* These can be changed to any number greater than zero  
	(the start chapter needs to be smaller than the end chapter)
<!-- end of the list -->
![Annotation 2020-08-09 171732](https://user-images.githubusercontent.com/50629201/122651413-f1cc3d80-d138-11eb-8ba6-5a254ee9b364.png)  
* Select a save folder by pressing the ***folder*** button  
* Check ***each catoon*** for the application to save all chapters of a cartoon under a common folder (***each chapter*** works likewise)  
###### There are multible ways chapters can be saved:  
* ***PDF file:***  every image of a given chapter is saved as a page in a PDF document. This results in one PDF file per chapter.
* ***CBZ file:***  chapters are saved as a Comic book archive file. Learn more [here](https://en.wikipedia.org/wiki/Comic_book_archive).
* ***multiple images:***  every image is saved seperately. The number of images per chapter can vary.
* ***one image:***  every image of a given chapter is stitched together verically to create one very tall image per chapter.
###### Warning: if a chapter is so long that the resulting merged image exceeds 30,000 pixels in height it will be down scaled (in some cases even until the text isn't readable anymore). In those cases the PDF option may be better.   
* Now you can click the ***start*** button and wait (all controls should be deactivated until the download is done)  

## used packages
- **HtmlAgilityPack** - for parsing HTML
- **ITextSharp** - for converting images to a PDF file
