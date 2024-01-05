#include "pch.h"
#include "attempt.h"

Attempt::Attempt(int x) {
	this->x = x;
}
int Attempt::adding(int y) {
	return this->x + y;
}