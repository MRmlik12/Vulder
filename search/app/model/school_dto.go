package model

type SchoolDTO struct {
	Name           string `json:"name"`
	URL            string `json:"url"`
	RequesterEmail string `json:"requester_email"`
}
