#include "lib.h"

int SumVector::sum(const std::vector<int> & inputVec) {
	int s = 0;
	for (auto i : inputVec) {
		s += i;
	}
	return s;
}