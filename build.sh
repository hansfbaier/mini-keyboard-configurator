for i in *.resx; do resgen $i; done
RESOURCES=$(for i in *.resources; do echo -resource:$i; done)
mcs -debug *.cs -reference:System.Windows.Forms,System.Drawing $RESOURCES -out:MiniKeyboard.exe
