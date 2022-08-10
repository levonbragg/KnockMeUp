# KnockMeUp

Simple tool to help implement "Port Knocking".
I created this because I wanted an easy to use GUI for port knocking that allowed me to save the servers.
Also, why use someone elses, when you can poorly hack together you own?

With UDP you can send a string in the packet and do L7 analysis on the packet on the recipient side.
More than just hitting a port, looking into the packet for a string...

With TCP, because we are not making a connection, (The server should be dropping the incoming connection) we cannot send the string data and it will be ignored.
It will just knock on the TCP port.

Because you can set the type for each packet you can mix and match for your port knocking pleasure.

![image](https://user-images.githubusercontent.com/9368955/183831093-5140bffc-ced2-46c2-b0b2-d906dc1ec341.png)

This version also includes the option to "Duplicate Packets" if you or the device is on a lossy connection. This can help "Knock" successfully.
Additionally, this version includes a "Keep Alive" function. This will "Knock" again every x number of seconds while the box is checked. 
This allows you to set a shorter time out on the server. The app will keep "knocking" to keep you on the allowed list.

Saves servers in a servers.json file. 1 object per line.
