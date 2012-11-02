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

### Available parameter values

Great if you want to present all the options in the client application, for instance in a drop-down list.

Mapping all these values will be an ongoing process, wouldn't mind some pull requests as help.

**Levels**

This is an enum, use as is.

**Formations**
```
IEnumerable<Formation> formations = Formation.GetAll();
```

**Leagues**
```
IEnumerable<League> leagues = League.GetAll();
```

**Nations**
```
IEnumerable<Nation> nations = Nation.GetAll();
```

**Positions**
```
IEnumerable<Position> positions = Position.GetAll();
```

**Teams**
```
IEnumerable<Team> teams = Team.GetAll();
```