# Makefile

a:
	make TestString
	make TestArray
	make TestDictionary

TestString:
	mcs -t:library ../../unicat/Ext/StringExt.cs -out:StringExt.dll
	mcs -t:library -r:nunit.framework,StringExt TestString.cs
	nunit-console -nologo                       TestString.dll

TestArray:
	mcs -t:library ../../unicat/Ext/ArrayExt.cs -out:ArrayExt.dll
	mcs -t:library -r:nunit.framework,ArrayExt  TestArray.cs
	nunit-console -nologo                       TestArray.dll

TestDictionary:
	mcs -t:library ../../unicat/Ext/DictionaryExt.cs -out:DictionaryExt.dll
	mcs -t:library -r:nunit.framework,DictionaryExt  TestDictionary.cs
	nunit-console -nologo                            TestDictionary.dll
