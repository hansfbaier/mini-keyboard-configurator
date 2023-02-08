#!/bin/bash
mono --debug --debugger-agent=transport=dt_socket,server=y,address=127.0.0.1:55555 MiniKeyboard.exe
