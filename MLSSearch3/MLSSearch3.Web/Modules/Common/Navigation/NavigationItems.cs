using Serenity.Navigation;
using Administration = MLSSearch3.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]
[assembly: NavigationMenu(2000, "MLS Database", icon: "icon-anchor")]
[assembly: NavigationLink(2100, "MLS Database/RegionList", typeof(MLSSearch3.Mls.Pages.RegionListController), icon: "icon-screen-desktop")]
[assembly: NavigationLink(2200, "MLS Database/CityList", typeof(MLSSearch3.Mls.Pages.CityListController), icon: "icon-screen-desktop")]
[assembly: NavigationLink(2300, "MLS Database/CityDistrictList", typeof(MLSSearch3.Mls.Pages.CityDistrictListController), icon: "icon-screen-desktop")]
[assembly: NavigationLink(2400, "MLS Database/CitySubAreaList", typeof(MLSSearch3.Mls.Pages.CitySubAreaListController), icon: "icon-screen-desktop")]
[assembly: NavigationLink(2500, "MLS Database/NeighborhoodList", typeof(MLSSearch3.Mls.Pages.NeighborhoodListController), icon: "icon-screen-desktop")]
[assembly: NavigationLink(2600, "MLS Database/SurreyDeltaApartment2016Ytd", typeof(MLSSearch3.Mls.Pages.SurreyDeltaApartment2016YtdController), icon: "icon-screen-desktop")]
[assembly: NavigationMenu(9000, "Administration", icon: "icon-screen-desktop")]
[assembly: NavigationLink(9000, "Administration/Exceptions Log", url: "~/errorlog.axd", permission: MLSSearch3.Administration.PermissionKeys.Security, icon: "icon-ban", Target = "_blank")]
[assembly: NavigationLink(9000, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
[assembly: NavigationLink(9000, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof(Administration.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof(Administration.UserController), icon: "icon-people")]