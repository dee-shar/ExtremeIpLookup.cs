#!/bin/bash

api="https://extreme-ip-lookup.com"
api_key="demo2"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function set_api_key() {
	# 1 - api_key: (string): <api_key - default: demo2>
	api_key=$1
}

function get_ip_info() {
	# 1 - ip_address: (string): <ip_address>
	curl --request GET \
		--url "$api/json/$1?key=$api_key" \
		--user-agent "$user_agent"
}

function get_own_ip_info() {
	curl --request GET \
		--url "$api/json?key=$api_key" \
		--user-agent "$user_agent"
}
