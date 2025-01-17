﻿namespace ConnectBot.Application.Constants
{
    public static class TextConstants
    {
        public const string PrivacyPolicyText =
            $"Привет!{EmojiConstants.HelloEmoji}\r\nЧтобы обеспечить работу нашего бота, мы собираем ваши данные, такие как имя, фамилия и никнейм в Telegram.\r\nИспользование бота означает ваше согласие с нашей политикой конфиденциальности.";

        public const string WelcomeBotText =
            $"Меня зовут Neko.{EmojiConstants.RobotEmoji}\r\nЯ виртуальный робот молодежной команды.{EmojiConstants.TeamEmoji}\r\n\r\nОчень хочу дружить с тобой {EmojiConstants.WowEmoji} \r\nЗалетай к нам, пользуйся кнопками внизу{EmojiConstants.DownEmoji} и наслаждайся.{EmojiConstants.HeartEmoji}";

        public const string CommunicationRequestResponseText = $"{EmojiConstants.HugsEmoji} Мы приняли твой запрос! Скоро кто-нибудь подойдет тебя обнять. Не убегай! {EmojiConstants.LaughingEmoji}";
        public static Func<string, string> CommunicationRequestHandlerText = author => $"{EmojiConstants.ExclamationMarkEmoji} Запрос на объятия от {author}";

        public static string FeedbackText = $"Здесь можно написать сообщение, фидбэк или идеи команде. Кликни на поле ввода, чтобы начать ввод текста. {EmojiConstants.DownEmoji}";
        public static string FeedbackResponseText = $"Большое спасибо, что связался с нами. Твое мнение ценно для нас {EmojiConstants.HeartEmoji}";
        public static Func<string, string, string> NewFeedbackHandlerText = (author, text) => $"{EmojiConstants.ExclamationMarkEmoji} Новый фидбек от {author}: \r\n{text}";

        public static string NotFoundTodayEventText = "Нет событий сегодня";
        public static string AlreadyCheckedInText = $"Ты уже зачекинился. Наслаждайся там! {EmojiConstants.WowEmoji}";
        public static Func<string, string, string, string> CheckedInText = (uniqueNumber, teamColor, connectName) => $"{connectName}\r\n\r\n{EmojiConstants.DoneEmoji}Ты зачекинился. Спасибо!\r\n\r\nТвой номер - {uniqueNumber}\r\nЦвет команды - {teamColor}\r\n\r\nНаслаждайся там! {EmojiConstants.WowEmoji}";

        public static Func<string, string, string> AllParticipationsText = (eventName, usersList) => $"Все участники {eventName}: \r\n\r\n{usersList}";

        public const string OkText = $"Ок{EmojiConstants.OkEmoji}";
        public const string NoText = "Нет";

        public const string SocialNetworksText = $"Вот все наши социальные сети. Подписывайся и будь в курсе событий! {EmojiConstants.PhoneEmoji}";
        public const string SocialNetworksInstagramText = $"{EmojiConstants.CameraEmoji} Instagram";
        public const string SocialNetworksTelegramNewsText = $"{EmojiConstants.NoteEmoji} Sila news";
        public const string SocialNetworksSiteText = $"{EmojiConstants.GlobeEmoji} Sile web-site";
    }
}
