<p align="center">
  <img width="350" src="https://i.imgur.com/sP6ihGS.png"/>
</p>

<h1 align="center">TCPIP_CHAT</h1>
<p align="center">
  <a href=#about>About</a> &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href=#technologies>Technologies</a> &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href=#features>Features</a> &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href=#error-handling>Error Handling</a> &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href=#setup>Setup</a> &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href=#images>Images</a> &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href=#developers>Developers</a>
</p>

## About
Application developed with C# and TCP Sockets for our college project. <br>
The project was developed in brazilian portuguese, so the error messages will also be.

## Technologies
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-5.0)
- [TCP Sockets](https://en.wikipedia.org/wiki/Network_socket)

## Error handling
Here are the errors that are handled by our application:
- Client side
  - Invalid IP
  - Empty user name
  - User name starting with numbers
  - Server offline
  - User name "administrador" or "Administrador"
  - User name already connected in the server IP

<br>

- Server Side
  - Invalid IP
  - Port already in use

## Setup

Clone the repository
``` bash
git clone https://github.com/CarlMartins/Chat_TCPIP.git
```
Run the server and client executables at:
``` bash
# Client
$ Executables/Cliente/Cliente.exe

# Server
$ Executables/Servidor/Servidor.exe
```

<strong>Run at least 1 server instance and 2 clients to make the chat happen.</strong>

## Features
- Backup
  - When you close the server application, all the clients will be kicked and a backup file with ```.txt``` format will be createad at the same location as the server executable.
  - The name format of the backup is ```DD-MM-YYYY HHmmss.txt```
- Emoticons for clients

## Images
<p align="center"> 
  <img src="https://i.imgur.com/mX5bgNK.png" alt="Program images"/>
</p>

<hr>

## Developers

<p>
Made by
<strong>
  <a href="https://github.com/CarlMartins">Carlos Martins</a>
</strong>
  and
  <strong>
  <a href="https://github.com/yuryrodri">Yury Shelkovsky</a>
  </strong>
</p>

<p>

Visit our LinkedIn
<a href="https://www.linkedin.com/in/carlos-alberto-lemos-martins-oliveira-189b291b5/">Carlos Martins</a> |
<a href="https://www.linkedin.com/in/yury-shelkovsky-a44529163/">Yury Shelkovsky</a>
</p>


