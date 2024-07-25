# SharpGram

> #### Telegram [Mtproto](https://core.telegram.org/mtproto) Library written in C#

***
*this is an opinion(around code design not mtproto itself) based implementation mainly
focused on features and alongside with code best practices.*

*it should not bring extra complexity to the projects and allow developers to focus and business logic rather than dealing with
implementation details around mtproto*

**this library does not focus on being the backend for GUI clients and creating apps for normal users;
the main focus of this library is creating automated tasks and user bots.**

***
## Use

this project is not on nuget yet, because its not ready to be used in the real world, yet.

you can clone the project and build it yourself.

it will be released on nuget in the future.

## Todo list

there are a lot of `//TODO` comments everywhere in project. I'll mention the important ones here.

- [ ] update handling.
- [ ] Proper logging (allow users to choose between log levels and the ability to have any log implementation they want, e.x serilog, nlog...etc.).
- [ ] writing more unit tests for the project.
- [ ] Proper session implementation. (currently its just plain normal json... which is not very awesome). it can be more flexible and generic, so it can be stored anywhere with ease.
- [ ] handling more errors and making the library more resilient.
- [ ] custom reconnection and retry policies (allow uses to check their own condition to decide if they want to retry/reconnect on different cases).
- [ ] more abstractions for the Client in general.
- [ ] moving away from OOP style to more FP approaches in different parts of the code, something like [this](https://github.com/MrAliSalehi/WTelegramClient.Abstractions.Types).
- [ ] refactoring the client so that it can be flexible on Connection Type (tcp,udp...etc.) and Transport layers(currently it can change between transport layers but that socket type is hard coded, even tho they are both defined as generics).
- [ ] reviewing and optimizing encryption and serialization/deserialization process.
- [ ] multi account management.
- [ ] writing a better generator. (at the beginning it was written with source-generator but due to its limitations around `File` and `HttpClient` it was refactored into normal console app.) currently the schema has to be updated manually and be deployed with the core library, which isn't very optimal.
- [ ] add build and test actions on GitHub.
## Credits

writing this project was a great (and hard) journey for me, but it could not be achieved alone.

special thanks to:
- [lonami](https://github.com/lonami/) for his helps and inspirations with [grammers](https://github.com/Lonami/grammers) and [Telethon](https://github.com/LonamiWebs/Telethon).
- [Wizou](https://github.com/wiz0u/) for his guidance and inspirations with [WTC](https://github.com/wiz0u/WTelegramClient).
- [mIwr](https://github.com/mIwr) for [his Aes-Ige implementation](https://github.com/mIwr/AesIge) that is used in this project.
  - > I did not use his nuget package directly due to the changes that was needed to his source code. 
- [davide](https://github.com/davidegalilei/piltover) for his server-side implementation of mtproto, [piltover](https://github.com/davidegalilei/piltover).
- [alina](https://github.com/teidesu) for her great inspirations with [mtcute](https://github.com/mtcute/mtcute).
- [Roj](https://github.com/rojvv) for his great project [MTKruto](https://github.com/MTKruto/MTKruto).


*I've mentioned/referenced every piece of code that I've copied from any source in the code comments,
I might have forgotten some of them which I apologize for it; please let me know if you saw any code without credits.*

## Contribution

dear contributor, before opening a PR please discuss your ideas either in the [discussions](https://github.com/MrAliSalehi/SharpGram/discussions/new/choose) or [telegram](https://t.me/the_alisalehi).
