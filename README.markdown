## Sample usage ##

### Login ###

```csharp
var loginRequest = new LoginRequest();
await loginRequest.LoginAsync("e-mail", "password", "secret answer");
```

### Search ###

```csharp
var searchRequest = new SearchRequest();
var searchParameters = new SearchParameters
{
	Page = 1,
    Level = Level.Gold,
	Type = "player"
};

var searchResponse = await searchRequest.SearchAsync(searchParameters);
foreach (var auctionInfo in searchResponse.AuctionInfo)
{
	// Handle auction data
}
```