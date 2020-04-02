# .NET Sales application using EventStore

Sample .NET Core API using EventStore.

## API
### director/
    * `getAllSales` : get the list of all the sales
    * `getToTalAmount` : get the total amount (sum) of sales 
### InventoryManager/
    * `getAll`  : get the list of all the sold product and the sold quantity of each
### saleman/
    * `addSale` : add new sale with all the related information
## Images 
    we used postman to test he api and check the returned values
* this images shows the request for adding new event of new sale "saleman/addSale" and the created data of the stored event 
    ![](img/addingNewSale.png)
* this images shows the created and stored event due to adding new sale 
    ![](img/eventContent.png)
* this images shows the extracted list of sales from the list of stored events 
    ![](img/listOfAllTheSales.png)
* this images shows the creted stream within eventStore and its content (the set of events) 
    ![](img/mystreamInEventstore.png)
* this images shows the returned list of sold products and the sold quantity of each extracted from the the stored events  
    ![](img/productsAndTheTotalSoldQuantityOfEach.png)
* the total amount was returned with the list of all sales but we provided another method to extract it independently as shown in the code





