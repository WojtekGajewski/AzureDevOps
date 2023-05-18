using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02SasSExample
{
    class SpeechServiceTool
    {
        string apiKey = "583fefb49a9849b7b8630d9901aca505";
        public async Task<string> RecognizeAsync()
        {
            var conf = SpeechConfig.FromSubscription(apiKey, "eastus");
            return await RecognizeFromMic(conf);
        }

        //dotnet add package Microsoft.CognitiveServices.Speech
        private async Task<string> RecognizeFromMic(SpeechConfig speechConfig)
        {
            using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            using var recognizer = new SpeechRecognizer(speechConfig, "pl-PL", audioConfig);

            var result = await recognizer.RecognizeOnceAsync();
            return result.Text;
        }
    }
}