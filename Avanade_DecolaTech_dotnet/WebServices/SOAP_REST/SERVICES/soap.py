from zeep import Client

client = Client('http://soapclient.com/xml/soapresponder.wsdl')
#result = client.service.Method1(bstrParam1='oi', bstrParam2='tchau')
result = client.service.Method1(bstrParam2='tchau', bstrParam1='oi')
#result = client.service.Method1('tchau', 'oi')
print(result)
