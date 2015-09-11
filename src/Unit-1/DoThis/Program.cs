using System;
﻿using Akka.Actor;

namespace WinTail
{
    #region Program
    class Program
    {
        public static ActorSystem MyActorSystem;

        static void Main(string[] args)
        {
            // initialize MyActorSystem
            // YOU NEED TO FILL IN HERE
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            // time to make your first actors!

            var consoleWriterProps = Props.Create(() => new ConsoleWriterActor());
            var consoleWriterActor = MyActorSystem.ActorOf(consoleWriterProps, "consoleWriterActor");

            var tailCoordinatorActor = MyActorSystem.ActorOf(Props.Create<TailCoordinatorActor>(), "tailCoordinatorActor");

            var validationActorProps = Props.Create(() => new FileValidatorActor(consoleWriterActor));
            var validationActor = MyActorSystem.ActorOf(validationActorProps, "validationActor");
            var consoleReaderProps = Props.Create<ConsoleReaderActor>();
            var readerActor = MyActorSystem.ActorOf(consoleReaderProps, "consoleReaderActor");

            // tell console reader to begin
            //YOU NEED TO FILL IN HERE
            readerActor.Tell(ConsoleReaderActor.StartCommand);

            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.AwaitTermination();
        }
    }
    #endregion
}
