using Azure;
using Azure.Data.Tables;
var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsawg;AccountKey=lA979+RwVRM3YnxT7Sg8yeJgHYKx2HxEu94cHjq44KzwsdXC55lpszfwZ9WldmZDrjJSkaBUPlbJ+ASt99h50w==;EndpointSuffix=core.windows.net";
//var containerName = "volleyballpictures";
var tableName = "Persons";
var tableClient = new TableClient(connectionString, tableName);
//CREATION
/*
// Create a table in your storage account
await tableClient.CreateIfNotExistsAsync();
// Insert an entity into the table
var entity = new TableEntity("volleyball", "player6")
{
{ "firstname", "john" },
{ "phone", "502893029" },
};
await tableClient.AddEntityAsync(entity);
Console.WriteLine("Entity added to the table.");
//*/

// Query entities from the table

/*var entity = new TableEntity("volleyball", "player6");
string partitionKeyFilter = $"PartitionKey eq '{entity.PartitionKey}'";
await foreach (var e in tableClient.QueryAsync<TableEntity>(partitionKeyFilter))
{
    Console.WriteLine($"" +
        $"PartitionKey: {e.PartitionKey}, " +
        $"RowKey: {e.RowKey}, " +
        $"Property1: {e.GetString("country")},+" +
        $"Property2: {e.GetString("firstname")} " +
        $"Property3: {e.GetString("lastname")} " +
        $"Property4: {e.GetString("phone")}, ");
}*/
// Update an entity in the table
/*var entity = new TableEntity("volleyball", "player6");
entity["country"] = "NewValue1";
await tableClient.UpdateEntityAsync(entity, ETag.All);
Console.WriteLine("Entity updated in the table.");
*/
// Delete an entity from the table
var entity = new TableEntity("volleyball", "player6");
await tableClient.DeleteEntityAsync(entity.PartitionKey, entity.RowKey);
Console.WriteLine("Entity deleted from the table.");