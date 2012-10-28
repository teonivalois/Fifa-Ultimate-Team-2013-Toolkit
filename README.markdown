## Sample usage ##

### Login ###

```csharp
var loginRequest = new LoginRequest();
await loginRequest.Login("e-mail", "password", "secret answer");
```

### Search ###

```csharp
var searchRequest = new SearchRequest();
var searchParameters = new SearchParameters
{
	Page = 1,
    Level = "gold",
    Type = "player"
};

var searchResponse = await searchRequest.Search(searchParameters);
foreach (var auctionInfo in searchResponse.AuctionInfo)
{
	// Handle auction data
}
```