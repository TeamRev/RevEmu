RevEmu
------

Revolution Emulator (RevEmu, revemu, Rev) is a new Habbo Hotel emulation
environment, designed to work with Habbo�s flash protocol. 

Built around speed & stability, Rev offers a brand new & open source
alternative to popular environments such as Butterfly & Phoenix, both of
which are proprietary and out of date. It is a modularised server,
allowing you to add components and remove components. Revolution is a
product of hard work and sustained development over a period of 10
months.

## Information

Rev�s current developers (as of time of writing) are:

-   Zak
-   Adil

## Contributing

Fork the project


    $ git clone https://github.com/TeamRev/RevEmu.git
	$ git remote add upstream https://github.com/TeamRev/RevEmu.git
	$ git fetch upstream
	
Then you push, as you do with a normal repo. 

## Unit Tests
Coming soon.

## License
See LICENSE

## Plugin Docs

Coming soon. For now, you can expose:

    var Message = Scripting.Message();
	var Habbo = Scripting.Habbo(id);
	var Console = Scripting.Console();
	var TCP = Scripting.TCP();
	
See this pastie for a very brief overview of the Console & TCP API's.
http://pastie.org/private/g11lusxmdqahdppxklj9zg

More will arrive when the engine has been updated.

