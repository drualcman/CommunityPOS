# CommunityPOS

We want a POS application to work offline and create sales.
System will get all the enviroment in the first load from some API.
Start sales process and capture the money.
In some moment we will send back all the sales to the API.

## Entities
	- Products
		SKU
		Barcode
		Name
		Price
		UnitsInStock
		CategoryId
		TaxId
		MeasureId
	- Categories
		Id
		Name
	- Taxes
		Id
		Name
		Percentage
	- Measures
		Id
		Name
	- SellerUser
		Id
		Name
		Password
	- PaymentsType
		Id
		Name
	- Printers
		Id
		Name
	- Sales
		Id
		CreatedDate
		SellerUserId
	- SalesDetail		
		ProductSKU
		Qty
		Price
		DiscountPercentage
	- SalesPayment
		PaymentsTypeId
		Amount


## Use Cases Basic Definitions
1. Get Enviroment
	1. Get Categories
	2. Get Items
	3. Get Payment Methods
	4. Get Users
	5. Get Printers
	6. Get TAXs

2. Open Session

3. Start Sale

4. Register the sale

5. End Of Day
	