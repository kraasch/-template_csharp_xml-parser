
all:
	make clean
	make build
	make run

build:
	mkdir -p ./build/
	mcs ./src/parse_xml.cs -r:System.Xml.Linq.dll -o ./build/parse_xml.exe

clean:
	rm -rf ./build/

run:
	mono ./build/parse_xml.exe
