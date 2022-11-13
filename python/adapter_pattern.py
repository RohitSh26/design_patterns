

class Bird:
    def fly(self):
        print('Bird Flying...')
    
    def make_sound(self):
        print('Bird chirp...chirp..')

class ToyDuck:
    def squeak(self):
        print('Toy Squeaking...')

class BirdAdapter(object):
    def __init__(self, object):
        self.object = object
    
    def squeak(self):
        print('Adapter.....')
        self.object.make_sound()

bird = Bird()
toy = ToyDuck()

# adapter
birdAdapter = BirdAdapter(bird)

print(bird.fly())
print(bird.make_sound())

print(toy.squeak())

print(birdAdapter.squeak())