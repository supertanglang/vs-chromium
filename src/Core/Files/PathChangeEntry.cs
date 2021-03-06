// Copyright 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

namespace VsChromium.Core.Files {
  public struct PathChangeEntry {
    private readonly FullPath _path;
    private readonly PathChangeKind _kind;

    public PathChangeEntry(FullPath path, PathChangeKind kind) {
      _path = path;
      _kind = kind;
    }

    public FullPath Path { get { return _path; } }
    public PathChangeKind Kind { get { return _kind; } }

    public override string ToString() {
      return string.Format("Change: Path=\"{0}\", Kind={1}", Path.Value, Kind);
    }
  }
}