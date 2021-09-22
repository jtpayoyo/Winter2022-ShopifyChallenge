# Winter2022-ShopifyChallenge
A simple inventory manager application made using Windows Forms for the Winter 2022 Shopify Developer Intern Challenge Question. I programmed it in C# using the .NET Core 3.1 framework. 

**Quick Start**
1. Copy the ChicksWithHats folder into the root folder of your C: drive.
      - These images will be added to the database. 
2. The project requires an instance of MyImageDB in SQLExpress. Run createMyImageDB_JP.sql in SSMS.
      - This requires SQL Server Management Studio (SSMS) and SQL Express
      - Download SSMS here: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15
      - Download SQL Express here: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
3. Run the executable file InventoryManagerGUI.exe located in (Winter2022-ShopifyChallenge\InventoryManager\InventoryManagerGUI\bin\Debug\netcoreapp3.1)

**Testing**
Validation and error handling for this app are handled in the GUI. Please see W2022-Shopify-Testing.docx for screenshots of the testing process.

**Project Goals**
1. Displays item data from an SQL database in frmMain
      - Includes item ID, name, description, quantity, factory price, factory discount, item price and item discount
      - Factory price/discount are how much these items can be purchased to increase quantity
      - Item price/discount are how much these items can be sold to decrease quantity
      -  Data grid view in frmMain has buttons for Edit, Buy and Sell
2. Allows user to edit data for items in frmDetail
      - Includes data validation for all editable fields
      - Item ID is not editable; this is a primary key in the database
      - Quantity is not editable; they must be bought/sold
      - Item image from the database is displayed
3. Allows user to buy/sell items in frmBuySell
      - User may not enter the sales form if the item is out of stock and is given a warning
      - User may sell up to as much stock is available
      - User may buy up to 500 items at once
      - Item image from the database is displayed here

**Potential Improvements**
1. Display item images on the main form
2. Allow users to add and delete items
3. Allow users to edit the item image
