use strict;
use warnings;
use Time::HiRes qw( time );

my $start = time();
my $i;
my $o;
my $e;
my $j;
my $prime_;
my @prime_;
my $p;
$o = 2;
$e = 10000;

for($i=$o; $i<=$e; $i++){
$p=0;
    for($j=1; $j<=$i; $j++){
        if($i % $j==0){

            $prime_[$p] = "$j";
            $p++;
        }
        if ($prime_[1] == $i){
        }
    }

}

my $end = time();
printf("%.2f\n", $end - $start);