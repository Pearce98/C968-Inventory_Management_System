I. User Interface

A.  Create a main form showing the following controls:

•   buttons for "Add," "Modify," "Delete," "Search" for parts and products, and "Exit"

•   lists for parts and products

•   text boxes for searching for parts and products

•   title labels for parts, products, and the application title


B.  Create an "Add Part" form showing the following controls:

•   radio buttons for "In-House" and "Outsourced" parts

•   buttons for "Save" and "Cancel"

•   text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID

•   labels for ID, name, inventory level, price or cost, max and min values, the form title, and company name or machine ID


C.  Create a "Modify Part" form with fields that populate with data from an existing part showing the following controls:

•   radio buttons for "In-House" and "Outsourced" parts

•   buttons for "Save" and "Cancel"

•   text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID

•   labels for ID, name, inventory level, price, max and min values, the form title, and company name or machine ID


D.  Create an "Add-Product" form showing the following controls:

•   buttons for "Save," "Cancel," "Add" part, and "Delete" part

•   text boxes for ID, name, inventory level, price, and max and min values

•   labels for ID, name, inventory level, price, max and min values, and the form title

•   a grid view for all parts

•   a grid view for parts associated with the product

•   a "Search" button and a text field with an associated list for displaying the results of the search


E.  Create a "Modify Product" form with fields that populate with data from an existing product showing the following controls:

•   buttons for "Save," "Cancel," "Add" part, and "Delete" part

•   text boxes for ID, name, inventory level, price, and max and min values

•   labels for ID, name, inventory level, price, max and min values, and the "all candidate parts" grid

•   a grid view for parts associated with the product

•   a "Search" button and a text box with an associated list for displaying the results of the search


II. Classes

F.  Create and implement the appropriate classes, methods, and properties as specified in the attached "UML Class Diagram."


G.  Add the following behaviors to the main form using the classes, methods, and properties implemented in part F:

•   redirect the user to the "Add Part," "Modify Part," "Add Product," or "Modify Product" forms

•   delete a selected part or product from the grid view

•   search for a part or product and display matching results

•   exit the main form


H.  Add the following behaviors to the part forms using the methods provided in the attached "UML Class Diagram":

1.  Add the following behaviors to the "Add Part" form:

•   select "In-House" or "Outsourced"

•   enter name, inventory level, price, max and min values, and company name or machine ID

•   save the data and then redirect to the main form

•   cancel or exit out of this form and go back to the main form

2.  Add the following behaviors to the "Modify Part" form:

•   select "In-House" or "Outsourced"

•   modify or change data values

•   save modifications to the data and then redirect to the main form

•   cancel or exit out of this form and go back to the main form


I.  Add the following behaviors to the product forms using the methods provided in the attached "UML Class Diagram":

1.  Add the following behaviors to the "Add Product" form:

•   enter name, inventory level, price, and max and min values

•   save the data and then redirect to the main form

•   associate one or more parts with a product

•   remove or disassociate a part from a product

•   cancel or exit out of this form and go back to the main form

2.  Add the following behaviors to the "Modify Product" form:

•   modify or change data values

•   save modifications to the data and then redirect to the main form

•   associate one or more parts with a product

•   remove or disassociate a part from a product

•   cancel or exit out of this form and go back to the main form


J.  Validate the user input to prevent the following four conditions:

•   non-numeric values in textboxes that expect numeric values

•   min from being greater than max; inventory from being outside the min and max bounds

•   the user deleting a part that is associated with a product

•   deleting a part or product without confirming it first
