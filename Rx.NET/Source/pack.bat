msbuild BuildCustom.proj

.nuget\nuget pack Rx-Core.nuspec -prop version=%1
.nuget\nuget pack Rx-Interfaces.nuspec -prop version=%1
.nuget\nuget pack Rx-Linq.nuspec -prop version=%1
.nuget\nuget pack Rx-Main.nuspec -prop version=%1
.nuget\nuget pack Rx-PlatformServices.nuspec -prop version=%1
.nuget\nuget pack Rx-Xaml.nuspec -prop version=%1
.nuget\nuget pack Rx-Testing.nuspec -prop version=%1