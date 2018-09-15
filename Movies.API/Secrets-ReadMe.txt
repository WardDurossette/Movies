This design pattern uses a secrets file that is kept outside 
of the Git repository.  During the main function, the secrets file
is added to the configuration.

Since this file is not included in the checked in source, you will have
to create it manually. The pattern is as follows:

JSON format, the same as the appsettings.json file, with any overrides 
that are wanted for Production, Testing, or Development.


