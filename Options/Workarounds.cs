﻿// Copyright 2017 Brian Allred
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

namespace NYoutubeDL.Options
{
    #region Using

    using System.Collections.Generic;
    using Helpers;

    #endregion

    /// <summary>
    ///     Object containing Workaround parameters
    /// </summary>
    public class Workarounds : OptionSection
    {
        [Option] private readonly BoolOption biDiWorkaround = new BoolOption("--bidi-workaround");
        [Option] private readonly StringOption encoding = new StringOption("--encoding");
        private readonly List<string> headers = new List<string>();
        [Option] private readonly IntOption maxSleepInternval = new IntOption("--max-sleep-interval");
        [Option] private readonly BoolOption noCheckCertificate = new BoolOption("--no-check-certificate");
        [Option] private readonly BoolOption preferInsecure = new BoolOption("--prefer-insecure");
        [Option] private readonly StringOption referer = new StringOption("--referer");
        [Option] private readonly IntOption sleepInterval = new IntOption("--sleep-interval");
        [Option] private readonly StringOption userAgent = new StringOption("--user-agent");

        /// <summary>
        ///     --bidi-workaround
        /// </summary>
        public bool BiDiWorkaround
        {
            get { return this.biDiWorkaround.Value ?? false; }
            set { this.biDiWorkaround.Value = value; }
        }

        /// <summary>
        ///     --encoding
        /// </summary>
        public string Encoding
        {
            get { return this.encoding.Value; }
            set { this.encoding.Value = value; }
        }

        /// <summary>
        ///     --max-sleep-interval
        /// </summary>
        public int MaxSleepInterval
        {
            get { return this.maxSleepInternval.Value ?? -1; }
            set { this.maxSleepInternval.Value = value; }
        }

        /// <summary>
        ///     --no-check-certificate
        /// </summary>
        public bool NoCheckCertificate
        {
            get { return this.noCheckCertificate.Value ?? false; }
            set { this.noCheckCertificate.Value = value; }
        }

        /// <summary>
        ///     --prefer-insecure
        /// </summary>
        public bool PreferInsecure
        {
            get { return this.preferInsecure.Value ?? false; }
            set { this.preferInsecure.Value = value; }
        }

        /// <summary>
        ///     --referer
        /// </summary>
        public string Referer
        {
            get { return this.referer.Value; }
            set { this.referer.Value = value; }
        }

        /// <summary>
        ///     --sleep-interval
        /// </summary>
        public int SleepInterval
        {
            get { return this.sleepInterval.Value ?? -1; }
            set { this.sleepInterval.Value = value; }
        }

        /// <summary>
        ///     --user-agent
        /// </summary>
        public string UserAgent
        {
            get { return this.userAgent.Value; }
            set { this.userAgent.Value = value; }
        }

        /// <summary>
        ///     --add-header
        /// </summary>
        /// <param name="header">
        ///     FIELD:VALUE pair to add as a header
        /// </param>
        public void AddHeader(string header)
        {
            this.AddHeader(header, false);
        }

        /// <summary>
        ///     --add-header
        /// </summary>
        /// <param name="header">
        ///     FIELD:VALUE pair to add as a header
        /// </param>
        /// <param name="overwrite">
        ///     Overwrite existing identical header (prevents duplicates)
        /// </param>
        public void AddHeader(string header, bool overwrite)
        {
            if (overwrite)
            {
                this.headers.Remove(header);
            }

            this.headers.Add(header);
        }

        public override string OptionsToCliParameters()
        {
            foreach (string header in this.headers)
            {
                this.CustomParameters.Add("--add-header");
                this.CustomParameters.Add(header);
            }

            return base.OptionsToCliParameters();
        }
    }
}