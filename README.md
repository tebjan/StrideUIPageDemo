## Render Stride UIPage in Scene
Quick demo of loading a UI page and using it's events in VL.
## How To Run
* Download latest [vvvv gamma](https://visualprogramming.net) with VL.Stride
* Open `UIPageInSceneDemo.vl`

![img](Screenshot.png)

## Edit Stride Project

### Install the vvvv Stride Fork
* Before running the Senko launcher, edit the file `%AppData%\NuGet\NuGet.Config` (sometimes `%AppData%\Roaming\NuGet\NuGet.Config`) to add the vvvv nuget feed:
```xml
<add key="vvvv-public-feed" value="http://teamcity.vvvv.org/guestAuth/app/nuget/v1/FeedService.svc/" />
```
* Running the Stride launcher now shows the vvvv builds of Stride
* Install the version that is used in the vvvv gamma that you are running
### Open Game Solution
* Start the Stride Game Studio and open `UITestGame/UITestGame.sln`
* Update all packages if you get asked