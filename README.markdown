## Sample usage ##

### Login ###

```csharp
var loginRequest = new LoginRequest();
await loginRequest.LoginAsync("e-mail", "password", "secret answer");
```

### Player search ###

```csharp
var searchRequest = new SearchRequest();
var searchParameters = new PlayerSearchParameters
{
	Page = 1,
    Level = Level.Gold
};

var searchResponse = await searchRequest.SearchAsync(searchParameters);
foreach (var auctionInfo in searchResponse.AuctionInfo)
{
	// Handle auction data
}
```