# InventoryManagementSystem

This project is a simple inventory management system designed to practice and implement OOP concepts.
## Interfaces

### IDisplay
- **Purpose**: Provides a uniform method for objects to display their details.

### IProduct
- **Purpose**: Defines the contract for all product objects with standard properties and methods necessary for inventory management.

### IMember
- **Purpose**: Specifies the functionalities that are common to all members, such as managing personal details and handling coupons.

### ICoupon
- **Purpose**: Standardizes the functionality for different types of coupons, ensuring consistency in how coupons are validated and applied.

## Classes

### Product (Abstract Class)
- **Inherits**: `IProduct`, `IDisplay`
- **Purpose**: Serves as the foundational class for all products, encapsulating common properties like ID, name, price, and quantity. Provides a standard interface for displaying and managing product information.

### Fridge, TShirt, TV, Milk
- **Inherits**: `Product`
- **Purpose**: These classes extend the `Product` class, adding specific properties and features relevant to their respective categories, such as capacity for fridges and resolution for TVs.

### Coupon (Abstract Class)
- **Inherits**: `ICoupon`, `IDisplay`
- **Purpose**: Acts as a base for all coupon types, offering common fields and methods like code, discount rate, and expiration date, as well as a standardized display method.

### BlackFriday, WinterFest
- **Inherits**: `Coupon`
- **Purpose**: Implement specific discount rules and validations associated with Black Friday and winter sales events.

### Transaction
- **Fields**: Include details like the associated coupon, product, and member.
- **Purpose**: Manages transaction details, tracking the stages of a sale from initiation to completion.
- **Enum `EStatus`**: Tracks the status of transactions, indicating different phases such as pending, completed, or refunded.

### Member
- **Inherits**: `IMember`, `IDisplay`
- **Purpose**: Manages member details and interactions with the system, such as adding or using coupons.

### IMSystem
- **Purpose**: Serves as the central management system, responsible for interactions between different system components such as members, products, and transactions.

### Program
- **Purpose**: Contains the entry point for the application, initializing and managing the startup flow of the system.

## Enums

### ECategory
- **Purpose**: Categorizes products to simplify management and retrieval.

### EStatus (within Transaction)
- **Purpose**: Enumerates the various statuses a transaction can have throughout its lifecycle, aiding in process management and user notifications.