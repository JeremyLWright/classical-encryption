
import io.kotlintest.specs.StringSpec
import main.kotlin.caesar.caesar
import main.kotlin.caesar.moduloAdd


class CaesarTests : StringSpec() {
    init {
        "module of a value should always be less than the modulous " {
            moduloAdd(3, 4, 2) shouldBe 1
        }

        "The reverse caesar cipher should alway be the original value" {
            caesar(caesar("HELLO", 3), -3) shouldBe "HELLO"
        }
    }
}