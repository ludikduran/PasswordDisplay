Password Display
================

Description
-----------
This module will provide a list of all users within the portal, their UserID, User Name, and Password. 
This module is a HUGE security risk and should not be used on a live production site.
	
For this module to work correctly, you have to be using encrypted password. Hashed passwords cannot be decrypted.
Any version earlier than 7.1.0 will have encrypted passwords by default. It is not recommended to use this module on version 7.1.0 or newer.
	
Install
-------
To install this module, take the install package from ~/Install and use it in Host > Extensions. You will then be able to place it on any page.
	
Troubleshooting
---------------
*Error:* Hashed passwords cannot be decoded
		
*Solution:* Web.config is currently set to use hashed passwords. Set the AspNetSqlMembershipProvider/passwordFormat to Encrypted. This will however not change current passwords to encrypted values in the database. Users will have to update their passwords to become encrypted.
	
Author
------
Ludik A Duran