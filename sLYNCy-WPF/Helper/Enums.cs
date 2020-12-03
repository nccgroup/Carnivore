//Released as open source by NCC Group Plc - https://www.nccgroup.com/

//Developed by Chris Nevin, chris.nevin@nccgroup.com

//https://www.github.com/nccgroup/carnivore

//Released under the AGPL license https://github.com/nccgroup/Carnivore/blob/master/license

namespace sLYNCy_WPF
{
    public class Enums
    {
        public enum SaveType
        {
            expo,
            autoLog
        }
        public enum GALRequest
        {
            Self,
            PersonalContacts,
            PeopleSearch
        }


        public enum MicrosoftService
        {
            Skype,
            Exchange,
            Office365,
            RDWeb,
            ADFS,
            Exchange2007,
            nullService
        }


        public enum HttpMethodChoice
        {
            GET,
            POST
        }

        public enum ChosenList
        {
            nullList,
            CouncilKiller,
            StandardAccounts,
            ServiceAccounts,
            UserFile
        }

        public enum SendingWindow
        {
            DomainEnum,
            UserEnum,
            PasswordSpray,
            AddressBook,
            MeetingSnooper
        }

        public enum URLType
        {
            UserEnum,
            Oauth,
            NTLM
        }

        public enum SendingButton
        {
            DomainEnumerate
        }

        public enum Regexs
        {
            SkypeRealAddress,
            NTLMResponse,
            NTLMResponseADFS,
            ADFSAuthURL,
            cwtToken,
            applicationsURL,
            sipUsername
        }


        public enum UsernameFileFormat
        {
            InBuilt,
            File,
            Enumerated
        }

        public enum UsernameEnumerationType
        {
            SmartEnumeration,
            Individual,
            UsernameList,
            nullMethod
        }

        public enum PasswordSprayType
        {
            UseDiscoveredFormat,
            UseChosenFormat,
            UsernameListCouncil,
            UsernameListService,
            UsernameListStandard,
            UsernameListFile,
            EnumeratedUsers,
            nullMethod
        }

        public enum UsernameFormat
        {
            nullFormat,
            jjs,
            jjsmith,
            john_smith,
            john,
            johnjs,
            johns,
            johnsmith,
            jsmith,
            smithj
        }
    }
}
