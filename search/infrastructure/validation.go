package infrastructure

import "regexp"

func GetRegexValidation(value string, regex string) (bool, error) {
	return regexp.Match(regex, []byte(value))
}

func IsEmpty(value string) bool {
	return value == ""
}
