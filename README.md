# Messenger
The Messenger component of the build also doubles as a login module (From where it was originally derived) for the prepack application.
It was requested that we add a instant messenger functionality to the existing notifications system. The system works on a MySQL table to both send and store messages and notifications.


Known issues include:
Memory leak on loading the same conversation several times (Rich Text Boxes not clearing from memory)
