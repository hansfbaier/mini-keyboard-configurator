EXE = MiniKeyboard.exe
DEBUG = -debug
SRCS = $(wildcard *.cs)
XML_RESOURCES = $(wildcard *.resx)
RESOURCES = $(patsubst %.resx,%.resources,$(XML_RESOURCES))
RES_ARGS = $(patsubst %.resources,-resource:%.resources,$(RESOURCES))

all: $(EXE)

%.resources: %.resx
	resgen $<

$(EXE): $(RESOURCES) $(SRCS)
	@mcs $(DEBUG) $(SRCS) -reference:System.Windows.Forms,System.Drawing $(RES_ARGS) -out:$@

run: $(EXE)
	./$(EXE) | ./usb-comm.py

clean:
	rm *.resources *.exe *.mdb -v -f

debug: $(EXE)
	@mono --debug --debugger-agent=transport=dt_socket,server=y,address=127.0.0.1:55555 MiniKeyboard.exe
