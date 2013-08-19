# Makefile

a:
	make TestString
	make TestArray
	make TestDictionary
	make TestNumber
	make TestUnicat

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

TestNumber:
	mcs -t:library ../../unicat/Ext/NumberExt.cs -out:NumberExt.dll
	mcs -t:library -r:nunit.framework,NumberExt  TestNumber.cs
	nunit-console -nologo                        TestNumber.dll

TestUnicat:
	mcs -t:library ../../unicat/Ext/StringExt.cs ../../unicat/Ext/ArrayExt.cs ../../unicat/Ext/DictionaryExt.cs ../../unicat/Ext/NumberExt.cs  -out:UnicatExt.dll
	mcs -t:library -r:nunit.framework,UnicatExt  TestUnicat.cs
	nunit-console -nologo                        TestUnicat.dll
