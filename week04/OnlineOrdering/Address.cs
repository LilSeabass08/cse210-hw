using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public string GetStreetAddress() { return _streetAddress; }
    public string GetCity() { return _city; }
    public string GetStateOrProvince() { return _stateOrProvince; }
    public string GetCountry() { return _country; }
}