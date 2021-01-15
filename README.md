# Cuer
> Cuer - QR Generator

Cuer is a minimalistic, NOJS QR Generator Webapp.

![Index](https://github.com/smnbhw/Cuer/raw/master/Readme%20Assets/GIF.gif)

## Features

- Strictly 100% No Javascript required
- Minimalistic and lightweight (Less than 20 KB)
- Fully responsive and QR is generated in SVG format

## Installation

OS X, Linux & Windows:
(git clone and run the following commands in the cloned directory)

```sh
dotnet restore
dotnet run
```

## Docker Instruction

Clone this git repository and inside the cloned directory, run the following commands to create a docker container:

```sh
docker build --tag cuer:latest .
docker run -d --name cuer -p 8080:80 cuer
```

Visit http://localhost:8080/ to access the WebApp.

## Usage Example

- Write or paste your text
- Hit generate and QR code in SVG will be generated

## Development Setup

Make sure to have .NET Core SDK installed on your machine. Git clone this repository and run the following in the cloned directory.

```sh
dotnet restore
```

## Meta

Distributed under the GNU GPLv3 license. See ``LICENSE.txt`` for more information.

[https://github.com/smnbhw/Cuer.git](https://github.com/smnbhw/Cuer.git)

## Thanks and Credits

[QRCoder](https://github.com/codebude/QRCoder) for the amazing library.


