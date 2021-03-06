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

    using Helpers;

    #endregion

    /// <summary>
    ///     Object containing Filesystem parameters
    /// </summary>
    public class Filesystem : OptionSection
    {
        [Option] private readonly IntOption autoNumberSize = new IntOption("--autonumber-size");
        [Option] private readonly IntOption autoNumberStart = new IntOption("--autonumber-start");
        [Option] private readonly StringOption batchFile = new StringOption("-a");
        [Option] private readonly StringOption cacheDir = new StringOption("--cache-dir");
        [Option] private readonly BoolOption continueOpt = new BoolOption("-C");
        [Option] private readonly StringOption cookies = new StringOption("--cookies");
        [Option] private readonly BoolOption id = new BoolOption("--id");
        [Option] private readonly StringOption loadInfoJson = new StringOption("--load-info-json");
        [Option] private readonly BoolOption noCacheDir = new BoolOption("--no-cache-dir");
        [Option] private readonly BoolOption noContinue = new BoolOption("--no-continue");
        [Option] private readonly BoolOption noMtime = new BoolOption("--no-mtime");
        [Option] private readonly BoolOption noOverwrites = new BoolOption("-w");
        [Option] private readonly BoolOption noPart = new BoolOption("--no-part");
        [Option] private readonly StringOption output = new StringOption("-o");
        [Option] private readonly BoolOption restrictFilenames = new BoolOption("--restrict-filenames");
        [Option] private readonly BoolOption rmCacheDir = new BoolOption("--rm-cache-dir");
        [Option] private readonly BoolOption writeAnnotations = new BoolOption("--write-annotations");
        [Option] private readonly BoolOption writeDescription = new BoolOption("--write-desription");
        [Option] private readonly BoolOption writeInfoJson = new BoolOption("--write-info-json");

        /// <summary>
        ///     --autonumber-size
        /// </summary>
        public int AutoNumberSize
        {
            get { return this.autoNumberSize.Value ?? 5; }
            set { this.autoNumberSize.Value = value; }
        }

        /// <summary>
        ///     --autonumber-start
        /// </summary>
        public int AutoNumberStart
        {
            get { return this.autoNumberStart.Value ?? 1; }
            set { this.autoNumberStart.Value = value; }
        }

        /// <summary>
        ///     -a
        /// </summary>
        public string BatchFile
        {
            get { return this.batchFile.Value; }
            set { this.batchFile.Value = value; }
        }

        /// <summary>
        ///     --cache-dir
        /// </summary>
        public string CacheDir
        {
            get { return this.cacheDir.Value; }
            set { this.cacheDir.Value = value; }
        }

        /// <summary>
        ///     -c
        /// </summary>
        public bool Continue
        {
            get { return this.continueOpt.Value ?? false; }
            set { this.continueOpt.Value = value; }
        }

        /// <summary>
        ///     --cookies
        /// </summary>
        public string Cookies
        {
            get { return this.cookies.Value; }
            set { this.cookies.Value = value; }
        }

        /// <summary>
        ///     --id
        /// </summary>
        public bool Id
        {
            get { return this.id.Value ?? false; }
            set { this.id.Value = value; }
        }

        /// <summary>
        ///     --load-info-json
        /// </summary>
        public string LoadInfoJson
        {
            get { return this.loadInfoJson.Value; }
            set { this.loadInfoJson.Value = value; }
        }

        /// <summary>
        ///     --no-cache-dir
        /// </summary>
        public bool NoCacheDir
        {
            get { return this.noCacheDir.Value ?? false; }
            set { this.noCacheDir.Value = value; }
        }

        /// <summary>
        ///     --no-continue
        /// </summary>
        public bool NoContinue
        {
            get { return this.noContinue.Value ?? false; }
            set { this.noContinue.Value = value; }
        }

        /// <summary>
        ///     --no-mtime
        /// </summary>
        public bool NoMtime
        {
            get { return this.noMtime.Value ?? false; }
            set { this.noMtime.Value = value; }
        }

        /// <summary>
        ///     -w
        /// </summary>
        public bool NoOverwrites
        {
            get { return this.noOverwrites.Value ?? false; }
            set { this.noOverwrites.Value = value; }
        }

        /// <summary>
        ///     --no-part
        /// </summary>
        public bool NoPart
        {
            get { return this.noPart.Value ?? false; }
            set { this.noPart.Value = value; }
        }

        /// <summary>
        ///     -o
        /// </summary>
        public string Output
        {
            get { return this.output.Value; }
            set { this.output.Value = value; }
        }

        /// <summary>
        ///     --restrict-filenames
        /// </summary>
        public bool RestrictFilenames
        {
            get { return this.restrictFilenames.Value ?? false; }
            set { this.restrictFilenames.Value = value; }
        }

        /// <summary>
        ///     --rm-cache-dir
        /// </summary>
        public bool RmCacheDir
        {
            get { return this.rmCacheDir.Value ?? false; }
            set { this.rmCacheDir.Value = value; }
        }

        /// <summary>
        ///     --write-annotations
        /// </summary>
        public bool WriteAnnotations
        {
            get { return this.writeAnnotations.Value ?? false; }
            set { this.writeAnnotations.Value = value; }
        }

        /// <summary>
        ///     --write-description
        /// </summary>
        public bool WriteDescription
        {
            get { return this.writeDescription.Value ?? false; }
            set { this.writeDescription.Value = value; }
        }

        /// <summary>
        ///     --write-info-json
        /// </summary>
        public bool WriteInfoJson
        {
            get { return this.writeInfoJson.Value ?? false; }
            set { this.writeInfoJson.Value = value; }
        }
    }
}