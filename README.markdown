## Sample usage

### Login

```csharp
var loginRequest = new LoginRequest();
await loginRequest.LoginAsync("e-mail", "password", "secret answer");
```

### Player search

All the search parameters are optional. If none are specified, you will get the 1st page of results with no filters applied.

```csharp
var searchRequest = new SearchRequest();
var searchParameters = new PlayerSearchParameters
{
    Page = 1,
    Level = Level.Gold,
    Formation = Formation.FourThreeThree,
    League = League.BarclaysPremierLeague,
    Nation = Nation.Norway,
    Position = Position.Striker,
    Team = Team.ManchesterUnited
};

var searchResponse = await searchRequest.SearchAsync(searchParameters);
foreach (var auctionInfo in searchResponse.AuctionInfo)
{
	// Handle auction data
}
```

### Player image

- Format: PNG
- Dimensions: 100 x 100 pixels

```csharp
var playerImageRequest = new PlayerImageRequest();
var imageBytes = await playerImageRequest.GetImageAsync(auctionInfo.ItemData.ResourceId);
```

### Item data

Contains info such as name, ratings etc.

```csharp
var itemRequest = new ItemRequest();
var item = await itemRequest.GetItemAsync(auctionInfo.ItemData.ResourceId);
```

### Available parameter values

Handy if you want to present all the options in the client application, for instance in a drop-down list.

Mapping all these values will be an ongoing process, wouldn't mind some pull requests as help.

**Levels**

This is an enum, use as is.

**Formations**
```csharp
IEnumerable<Formation> formations = Formation.GetAll();
```

**Leagues**
```csharp
IEnumerable<League> leagues = League.GetAll();
```

**Nations**
```csharp
IEnumerable<Nation> nations = Nation.GetAll();
```

**Positions**
```csharp
IEnumerable<Position> positions = Position.GetAll();
```

**Teams**
```csharp
IEnumerable<Team> teams = Team.GetAll();
```