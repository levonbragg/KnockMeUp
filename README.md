# KnockMeUp

Simple tool to help implement "Port Knocking".
I created this because I wanted an easy to use GUI for port knocking that allowed me to save the servers.
Also, why use someone elses, when you can poorly hack together you own?

With UDP you can send a string in the packet and do L7 analysis on the packet on the recipient side.
More than just hitting a port, looking into the packet for a string...

With TCP, because we are not making a connection, (The server should be dropping the incoming connection) we cannot send the string data and it will be ignored.
It will just knock on the TCP port.

Because you can set  the type for each packet you can mix and match for your port knocking pleasure.
